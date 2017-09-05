using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loggers;
using Writers;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConsoleLoggerTest()
        {
            var loggerMock = new ConsoleLogger();
            var message = "Hello World!";
            var expectedResult = $"Message:{message}";
            Assert.AreEqual(expectedResult, loggerMock.Log(message));
        }

        [TestMethod]
        public void TextWriterTest()
        {
            var writerMock = new ConsoleWriter();
            var message = "Hello World!";
            Assert.AreEqual(message, writerMock.WriteText(message));
        }
    }
}
