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

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void LogError_InvalidMessage_ThrowsArgumentNullException(string invalidMessage)
        {
            // Arrange
            var logger = new ErrorLogger();
            // Act
            //logger.LogError(invalidMessage);

            // Assert
            Assert.That(() => logger.LogError(invalidMessage), Throws.ArgumentNullException);
            //Assert.That(() => logger.LogError(invalidMessage), Throws.Exception.TypeOf<ArgumentNullException>());
        }
    }
}
