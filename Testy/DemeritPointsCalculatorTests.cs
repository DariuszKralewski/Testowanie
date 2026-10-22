using ConsoleApp1.Podstawy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testy
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_InvalidInput_ThrowsArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(0, 0)]
        [TestCase(50, 0)]
        [TestCase(51, 0)]
        [TestCase(55, 1)]
        [TestCase(60, 2)]
        public void CalculateDemeritPoints_ValidInput_ReturnsCorrectDemeritPoints(int speed, int expectedDemeritPoints)
        {
            var calculator = new DemeritPointsCalculator();
            var actualDemeritPoints = calculator.CalculateDemeritPoints(speed);
            Assert.That(actualDemeritPoints, Is.EqualTo(expectedDemeritPoints));
        }
    }
}
