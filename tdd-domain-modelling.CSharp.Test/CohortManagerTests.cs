using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        private CohortManager _core;
        private ShoppingBasket _basket;
        public CohortManagerTest()
        {
            _core = new CohortManager();
            _basket = new ShoppingBasket();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

       [Test]
        public void BasketTotalAddProductTest()
        {
            _basket.AddProduct("apple", 2);
            _basket.AddProduct("apple", 2);
            Assert.IsTrue(_basket.Basket["apple"] == 4);
        }

        [Test]
        public void BasketTotalRemoveProductTest()
        {
            _basket.RemoveProduct("apple", 1);
            Assert.IsTrue(_basket.Basket["apple"] == 3);
        }
        [Test]
        public void BasketTotalAddProductNotInStockTest()
        {
            _basket.AddProduct("toiletpaper", 2);
            Assert.False(_basket.Basket.ContainsKey("toiletpaper"));
        }

        [Test]
        public void BasketTotalCostTest()
        {
            Assert.AreEqual(_basket.Total(), 0.69);
        }
    }
}