using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessentOne {
    internal class Question4 {
        delegate void MyDelegate(string s);
        static public void PrintOnlyString(string s) {
            Console.WriteLine("Only String: " + s);
        }
        static public void Run() {
            MyDelegate myDelegate = new MyDelegate(PrintOnlyString);
            Console.WriteLine("Question4");
            Console.Write("Enter input:");
            string input = Console.ReadLine();
            myDelegate(input);
        }
    }
}
