using CSLogger.Base_Classes;
using CSLogger.Logger_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Extension_Classes
{
    public static class DoubleExtensions
    {
        public static void WriteToConsole(this double toWrite)
        {
            ConsoleLogger.Print(toWrite);
        }

        public static void WriteToConsole(this double doubleValue, string doubleDescription)
        {
            ConsoleLogger.Print($"{doubleDescription} : {doubleValue}");
        }

        public static void AddToInfoLog(this double doubleValue, string doubleDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(doubleValue, doubleDescription);
            LogBase.AddValueToInfoLog(formattedEntry);
        }

        public static void AddToErrorLog(this double doubleValue, string doubleDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(doubleValue, doubleDescription);
            LogBase.AddValueToInfoLog(formattedEntry);
        }
    }
}
