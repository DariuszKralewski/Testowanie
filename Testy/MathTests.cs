using ConsoleApp1.Podstawy;
using NUnit.Framework;
using System.Linq;

namespace Testy
{
    [TestFixture]
    public class MathTests
    {
        //SetUp - metoda, która jest wywoływana przed każdym testem. Można w niej tworzyć obiekty, które będą używane w testach.
        //TearDown - metoda, która jest wywoływana po każdym teście. Można w niej zwalniać zasoby, które były używane w testach.
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math(); //tworzę obiekt klasy Math
        }

        [TearDown]
        public void TearDown()
        {
            _math = null; //czyszczę obiekt klasy Math
        }

        [Test]
        [Ignore("Nie chce mi się. Zrobię to jutro")]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var result = _math.Add(1, 2); //wywołuję metodę Add i przypisuję wynik do zmiennej result
            Assert.That(result, Is.EqualTo(3)); //sprawdzam czy wynik jest równy 3
        }


        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsGreaterArgument(int first, int second, int expectedResult)
        {
            var result = _math.Max(first, second);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnsOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            //Specific
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            //More general
            Assert.That(result, Is.Not.Empty); //czy kolekcja nie jest pusta
            Assert.That(result, Has.Count.EqualTo(3)); //czy kolekcja ma 3 elementy
            Assert.That(result.Count(), Is.EqualTo(3)); //czy kolekcja ma 3 elementy
            Assert.That(result, Does.Contain(1)); //czy kolekcja zawiera 1
            Assert.That(result, Does.Contain(3)); //czy kolekcja zawiera 3
            Assert.That(result, Does.Contain(5)); //czy kolekcja zawiera 5  
            Assert.That(result, Is.Ordered); //czy kolekcja jest posortowana
            Assert.That(result, Is.Unique); //czy kolekcja nie zawiera duplikatów
            Assert.That(result.Sum(), Is.EqualTo(9)); //czy suma elementów jest równa 9

        }
    }
}
