using ConsoleApp1.Atrapy;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy.Atrapy
{
    [TestFixture]
    public class VideoServiceTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            //atrapa
            var fileReader = new Mock<IFileReader>();

            //sposób działania mocka
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var service = new VideoService(fileReader.Object);
            var result = service.ReadVideoTitle();
            Assert.That(result, Does.Contain("Error"));
        }
    }
}
