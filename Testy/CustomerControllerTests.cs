using ConsoleApp1.Podstawy;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_RetunsNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_RetunsOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(1);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
