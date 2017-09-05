using Loggers;
using System;
using System.Collections.Generic;
using System.Text;
using Writers;

namespace TextWriter
{
    public enum LogWriterType {
        Console,
        Log4J,
        ApplicationInsights
    }

    public enum TextWriterType
    {
        Console,
        Oracle,
        MangoDb
    }

    public static class GenericTextWriter
    {
        public static void WriteText(string text, TextWriterType textWriterType, LogWriterType logType)
        {
            switch (textWriterType) {
                case TextWriterType.Console:
                    var writer = new ConsoleWriter();
                    writer.WriteText(text);
                    break;
                case TextWriterType.Oracle:
                    throw new NotImplementedException();
                case TextWriterType.MangoDb:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }

            switch (logType) {
                case LogWriterType.Console:
                    var logger = new ConsoleLogger();
                    logger.Log(text);
                    break;
                case LogWriterType.Log4J:
                    throw new NotImplementedException();
                case LogWriterType.ApplicationInsights:
                    throw new NotImplementedException();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
