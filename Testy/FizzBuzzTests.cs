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
    public class FizzBuzzTests
    {
        [Test]
        public void GetFizzBuzz_InputDivisibleBy3And5_ReturnsFizzBuzz()
        {
            int input = 15;
            string result = FizzBuzz.GetFizzBuzz(input);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetFizzBuzz_InputDivisibleBy3Only_ReturnsFizz()
        {
            int input = 3;
            string result = FizzBuzz.GetFizzBuzz(input);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetFizzBuzz_InputDivisibleBy5Only_ReturnsBuzz()
        {
            int input = 5;
            string result = FizzBuzz.GetFizzBuzz(input);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetFizzBuzz_InputNotDivisibleBy3Or5_ReturnsNumber()
        {
            int input = 1;
            string result = FizzBuzz.GetFizzBuzz(input);
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
