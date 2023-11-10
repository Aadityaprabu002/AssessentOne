using System.Diagnostics;



namespace AssessentOne {
    internal class Question6 {
        static public void Run() {
            Console.WriteLine("Question 6");
            ProcessStartInfo startInfo = new ProcessStartInfo {
                FileName = "notepad.exe",
                UseShellExecute = true,   
            };

            try {
                // Start the process
                Process process = Process.Start(startInfo);

                if (process != null) {
                    Console.WriteLine($"Process ID: {process.Id}");
                    Console.WriteLine($"Process Name: {process.ProcessName}");

                    // Wait for the process to exit
                    process.WaitForExit();

                    Console.WriteLine("Process has exited.");
                } else {
                    Console.WriteLine("Failed to start the process.");
                }
            } catch (Exception ex) {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
