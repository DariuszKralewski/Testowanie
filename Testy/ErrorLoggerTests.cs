using ConsoleApp1.Podstawy;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void LogError_MessageIsProvided_LastErrorIsSet()
        {
            var logger = new ErrorLogger();
            logger.LogError("Test error message");
            Assert.That(logger.LastError, Is.EqualTo("Test error message"));
        }
    }
}
