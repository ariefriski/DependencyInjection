using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionTask
{
    public class FileLogger : ILogger
    {
        private readonly string _logFilePath;

        public FileLogger(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        public void Log(string message)
        {
            using (var writer = new StreamWriter(_logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - {message}");
            }
        }
    }
}
