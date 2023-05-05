using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTests
    {
        private Basket _basket;
        public BasketTests()
        {
            _basket = new Basket();
        }

        [TestCase("Apple", 1, true)]
        [TestCase("Meat", 5, true)]
        [TestCase("Fish", 3, false)]
        public void BasketAddTest(string name, int price, bool expected)
        {
            Assert.IsTrue(_basket.AddProduct(name, price) == expected);
        }

        [Test]
        public void BasketTotalTest()
        {
            Assert.AreEqual(_basket.Total(), 16);
        }

    }
}