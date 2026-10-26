using ConsoleApp1.Podstawy;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ReturnsTextWrappedInStrongTags()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //Specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            //More general
            Assert.That(result, Does.StartWith("<strong>")); //czy zaczyna się od <strong>
            Assert.That(result, Does.EndWith("</strong>")); //czy kończy się na </strong>
            Assert.That(result, Does.Contain("abc")); //czy zawiera abc
        }
    }
}
