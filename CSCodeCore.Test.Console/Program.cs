using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLogger;
using CSLogger.Extension_Classes;
using CSLogger.Logger_Classes;

namespace CSCodeCore.Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Integer Tests
            var test1 = 1;

            test1.AddToErrorLog(nameof(test1));
            test1.AddToInfoLog(nameof(test1));
            test1.WriteToConsole();
            test1.WriteToConsole(nameof(test1));

            #endregion

            #region Boolean Tests
            bool test2 = true;
            test2.AddToErrorLog(nameof(test2));
            test2.AddToInfoLog(nameof(test2));
            test2.WriteToConsole();
            test2.WriteToConsole(nameof(test2));
            #endregion

            #region String Tests
            string test3 = "test3";
            test3.AddToErrorLog(nameof(test3));
            test3.AddToInfoLog(nameof(test3));
            test3.WriteToConsole();
            test3.WriteToConsole(nameof(test3));
            #endregion

            #region Double Tests
            double test4 = 4.0;
            test4.AddToErrorLog(nameof(test4));
            test4.AddToInfoLog(nameof(test4));
            test4.WriteToConsole();
            test4.WriteToConsole(nameof(test4));
            #endregion

            #region Enumerable Tests
            var test5 = new List<double> { 1.0, 2.0, 3.0 };
            test5.WriteToConsole();
            test5.WriteToConsole(nameof(test5));
            #endregion

            ConsoleLogger.PrintErrorLog();
            ConsoleLogger.PrintInfoLog();

            FileLogger.WriteErrorLogToFile();
            FileLogger.WriteInfoLogToFile();

            System.Console.ReadKey();
        }
    }
}
