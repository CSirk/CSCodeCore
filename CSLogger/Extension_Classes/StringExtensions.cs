using CSLogger.Base_Classes;
using CSLogger.Logger_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Extension_Classes
{
    public static class StringExtensions
    {
        public static void WriteToConsole(this string toWrite)
        {
            ConsoleLogger.Print(toWrite);
        }

        public static void WriteToConsole(this string stringValue, string stringDescription)
        {
            ConsoleLogger.Print($"{stringDescription} : {stringValue}");
        }

        public static void AddToInfoLog(this string stringValue, string stringDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(stringValue, stringDescription);
            LogBase.AddValueToInfoLog(formattedEntry);
        }

        public static void AddToErrorLog(this string stringValue, string stringDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(stringValue, stringDescription);
            LogBase.AddValueToInfoLog(formattedEntry);
        }
    }
}
