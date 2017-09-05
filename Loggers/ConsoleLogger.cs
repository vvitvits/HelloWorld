using System;

namespace Loggers
{
    public class ConsoleLogger : ILogger
    {
        public string Log(string message)
        {
            var logText = $"Message:{message}";
            System.Console.WriteLine(logText);
            return logText;
        }
    }
}