using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessentOne {
    internal class Question7 {
       public static void Run() {

            Console.WriteLine("Question7");
            Console.Write("Enter Sub Key to be created:");
            string subKey = Console.ReadLine();

            Console.Write("\nEnter Value Name to be created:");
            string valueName = Console.ReadLine();

            Console.Write("\nEnter Value Data to be created:");
            string valueData = Console.ReadLine();


            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subKey);
            registryKey.SetValue(valueName, valueData);
            registryKey.Close();

            Console.WriteLine("Created successfully");

                 
        }
    }
}
