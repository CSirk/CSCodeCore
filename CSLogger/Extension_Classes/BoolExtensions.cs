using CSLogger.Base_Classes;
using CSLogger.Logger_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Extension_Classes
{
    public static class BoolExtensions
    {
        public static void WriteToConsole(this bool toWrite)
        {
            ConsoleLogger.Print(toWrite);
        }

        public static void WriteToConsole(this bool boolValue, string boolDescription)
        {
            ConsoleLogger.Print($"{boolDescription} : {boolValue}");
        }

        public static void AddToInfoLog(this bool boolValue, string boolDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(boolValue, boolDescription);
            LogBase.AddValueToInfoLog(formattedEntry);

        }

        public static void AddToErrorLog(this bool boolValue, string boolDescription)
        {
            var formattedEntry = LogBase.FormatLogEntry(boolValue, boolDescription);
            LogBase.AddValueToErrorLog(formattedEntry);
        }
    }
}
