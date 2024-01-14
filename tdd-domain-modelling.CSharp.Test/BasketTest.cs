using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        private Basket _basket;

        [SetUp]

        public void SetUp()
        {
            _basket = new Basket();
            _basket.add("Bread", 2);
            _basket.add("Bread", 2);
            _basket.add("Water", 1);
            _basket.add("Cheese", 3);
            _basket.add("Milk", 1);
        }


        [Test]

        public void TotalTest()
        {
            int totalPrice = _basket.total();
            Assert.That(totalPrice, Is.EqualTo(9));
        }

        [Test]
        public void EmptyTest()
        {
            _basket.clear();
            int totalPrice = _basket.total();
            Assert.That(totalPrice, Is.EqualTo(0));
        }


        [Test]
        public void TotalTest2()
        {
            _basket.remove("Bread");
            int totalPrice = _basket.total();
            Assert.That(totalPrice, Is.EqualTo(5));
        }

    }
}