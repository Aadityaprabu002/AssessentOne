using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessentOne {

    internal class Question10 {
        private static int availableSeats = 5; // Total number of available seats
        private static Semaphore semaphore = new Semaphore(1, 1); // Semaphore to control access
  
        public static void Run() {
          
            List<Thread> passengerThreads = new List<Thread>();

            for (int i = 1; i <= 10; i++) {
                

                Thread passengerThread = new Thread(new ParameterizedThreadStart(BookTicket));
                passengerThread.Name = $"Passenger-{i}";
                passengerThreads.Add(passengerThread);
            }

            Random random = new Random();
            foreach (Thread thread in passengerThreads) {
                thread.Start(random.Next(100,300));
            }

            // Wait for all threads to complete
            foreach (Thread thread in passengerThreads) {
                thread.Join();
            }

            Console.WriteLine("All passengers have completed their bookings.");
            Console.WriteLine($"Remaining available seats: {availableSeats}");
        }

        static void BookTicket(object randomTime) {
            Console.WriteLine($"{Thread.CurrentThread.Name} is trying to book a ticket.");
            Thread.Sleep((int)randomTime);
            semaphore.WaitOne();
            try { 
                if (availableSeats > 0) {
                    Console.WriteLine($"{Thread.CurrentThread.Name} booked a ticket.");
                    
                    availableSeats--;
                } else {
                    Console.WriteLine($"{Thread.CurrentThread.Name} couldn't book a ticket. No seats available.");
                }
            } finally {
                semaphore.Release(); 
            }
        }
    }
}
