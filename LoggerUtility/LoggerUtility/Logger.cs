using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerUtility
{
    internal static class Logger
    {
        private static readonly List<string> logEntries = new List<string>();

        public static void LogInfo(string message)
        {
            Log("INFO",  message);
        }

        public static void LogWarn(string message)
        {
            Log("WARNING", message);
        }

        public static void LogError(string message)
        {
            Log("ERROR", message);
        }

        public static void Log(string type, string message)
        {
            string logEntry = $"{DateTime.Now:G} [{type}] {message}";
            logEntries.Add(logEntry);
        }

        public static List<string> GetLogEntries()
        {
            return new List<string>(logEntries);
        }
    }
}
