using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Base_Classes
{
    public class LogBase
    {
        protected static List<string> InfoLog { get; set; } = new List<string>();
        protected static List<string> ErrorLog { get; set; } = new List<string>();

        public static void AddValueToInfoLog<T>(T valueToAdd)
        {
            AddValueToLog(InfoLog, valueToAdd);
        }

        public static void AddValueToErrorLog<T>(T valueToAdd)
        {
            AddValueToLog(ErrorLog, valueToAdd);
        }

        private static void AddValueToLog<T>(ICollection<string> logToAddTo, T value)
        {
            logToAddTo.Add(value.ToString());
        }

        internal static string FormatLogEntry<TValue, TDescription>(TValue value, TDescription description)
        {
            return $"{DateTime.Now} ::: {description} : {value}";
        }
    }
}
