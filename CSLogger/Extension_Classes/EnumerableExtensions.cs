using CSLogger.Logger_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Extension_Classes
{
    public static class EnumerableExtensions
    {
            public static void WriteToConsole<T>(this IEnumerable<T> toWrite)
            {
                var listOfValuesToPrint = toWrite.ToList();

                foreach (var value in listOfValuesToPrint)
                {
                    ConsoleLogger.Print(value);
                }
            }

            public static void WriteToConsole<T>(this IEnumerable<T> toWrite, string nameOfEnumerable)
            {
                var listOfValuesToPrint = toWrite.ToList();

                ConsoleLogger.Print(nameOfEnumerable);

                foreach (var value in listOfValuesToPrint)
                {
                    ConsoleLogger.Print(value);
                }
            }
        }
}
