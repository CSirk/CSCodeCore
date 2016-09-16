using CSLogger.Base_Classes;
using CSLogger.Logger_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Extension_Classes
{
    public static class IntegerExtensions
    {
        public static void WriteToConsole(this int toWrite)
        {
            ConsoleLogger.Print(toWrite);
        }

        public static void WriteToConsole(this int intValue, string intDescription)
        {
            ConsoleLogger.Print($"{intDescription} : {intValue}");
        }

        public static void AddToInfoLog(this int intValue, string intDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(intValue, intDescription);
            LogBase.AddValueToInfoLog(formattedEntry);
        }

        public static void AddToErrorLog(this int intValue, string intDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(intValue, intDescription);
            LogBase.AddValueToInfoLog(formattedEntry);
        }
    }
}
