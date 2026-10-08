using Aplikacja.Podstawy;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //sprawdzamy czy rezerwacja może być odwołana przez Admina
            // 3 razy A - AAA 
            // Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestMethod2()
        {
            //sprawdzamy czy rezerwacja może być odwołana przez użytkownika,
            //który ją zrealizował
            var user = new User(); //tworzę użytkownika
            var reservation = new Reservation { MadeBy = user }; //tworzę rezerwację i przypisuję do niej użytkownika}

            var result = reservation.CanBeCancelledBy(user); //sprawdzam czy rezerwacja może być odwołana przez użytkownika, który ją zrealizował

            Assert.That(result, Is.True); //sprawdzam czy wynik jest prawdziwy
        }

        [Test]
        public void TestMethod3()
        {
            var reservaration = new Reservation { MadeBy = new User() }; //tworzę rezerwację i przypisuję do niej użytkownika

            var result = reservaration.CanBeCancelledBy(new User()); //sprawdzam czy rezerwacja może być odwołana przez innego użytkownika

            Assert.That(result, Is.False); //sprawdzam czy wynik jest fałszywy
        }
    }
}
