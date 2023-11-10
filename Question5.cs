using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessentOne {
    class UserDefinedException : Exception {
        public UserDefinedException(string message) : base(message) { }
    }
    internal class Question5 {
        static public void Run() {
            Console.WriteLine("Question 5");
            Console.Write("Enter temp:");
            string input = Console.ReadLine();
            try {
                if(input != "34") {
                    throw new UserDefinedException("Not room temp");
                }
            }
            catch(UserDefinedException e) {

                Console.WriteLine("Caught exception");
                Console.WriteLine(e.Message);
            }
        }
    }
}
