using CSLogger.Base_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Logger_Classes
{
    public class ConsoleLogger : LogBase
    {
            public static void PrintInfoLog()
            {
                PrintLog(InfoLog);
            }

            public static void PrintErrorLog()
            {
                PrintLog(ErrorLog);
            }

            public static void Print<T>(T message)
            {
                Console.WriteLine(message);
            }

            public static void Print<TName, TMessage>(TName name, TMessage message)
            {
                Console.WriteLine($"{name} : {message}");
            }

            public static void PrintError<T>(T errorMessage)
            {
                Console.WriteLine($"ERROR ::: {DateTime.Now} ::: {errorMessage} {Environment.NewLine}");
            }

            public static void PrintInfo<T>(T infoMessage)
            {
                Console.WriteLine($"INFO ::: {DateTime.Now} ::: {infoMessage} {Environment.NewLine}");
            }

            private static void PrintLog(IEnumerable<string> logToPrint)
            {
                foreach (var logEntry in logToPrint)
                {
                    Console.WriteLine(logEntry);
                }
            }
        }
}
