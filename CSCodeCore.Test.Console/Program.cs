using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLogger;
using CSLogger.Extension_Classes;

namespace CSCodeCore.Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = 1;
            var test2 = "two";
            var test3 = true;

            var listOfTest4 = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };

            test1.WriteToConsole(nameof(test1));
            test2.WriteToConsole();
            test3.AddToErrorLog(nameof(test3));

            listOfTest4.WriteToConsole();

           System.Console.ReadKey();
        }
    }
}
