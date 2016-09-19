using CSLogger.Base_Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLogger.Logger_Classes
{
    public class FileLogger : LogBase
    {
        public static void WriteErrorLogToFile(string path = "")
        {
            path = ReturnFullPath(path, "ErrorLog");

            WriteToFile(ErrorLog, path);
        }

        public static void WriteInfoLogToFile(string path = "")
        {
            path = ReturnFullPath(path, "InfoLog");

            WriteToFile(InfoLog, path);
        }

        private static void WriteToFile(IEnumerable<string> logToWrite, string path)
        {
            using (var sw = new StreamWriter(path, true))
            {
                foreach (var logEntry in logToWrite)
                {
                    sw.WriteLine(logEntry);
                }
            }
        }

        private static string ReturnFullPath(string path, string logType)
        {
            return (String.IsNullOrEmpty(path) ? Environment.CurrentDirectory : path) + $@"\{logType}.txt";
        }
    }
}
