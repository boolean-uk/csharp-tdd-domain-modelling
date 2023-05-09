using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        private CohortManager _core;
       
        public CohortManagerTest()
        {
            _core = new CohortManager();
        }

        [Test]
        public void Test1()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            Assert.Pass();
        }

       [Test]
        public void BasketTotalAddProductTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            Assert.IsTrue(_basket.Basket["banana"] == 7);
        }

        [Test]
        public void BasketTotalRemoveProductTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            _basket.RemoveProduct("banana", 1);
            Assert.IsTrue(_basket.Basket["banana"] == 6);
            Assert.IsFalse(_basket.Basket.ContainsKey("cleaner"));
        }
        [Test]
        public void BasketTotalAddProductNotInStockTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("toiletpaper", 2);
            Assert.False(_basket.Basket.ContainsKey("toiletpaper"));
        }

        [Test]
        public void BasketTotalCostTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            Assert.AreEqual(_basket.Total(), 7 * 0.44M);
        }

        [Test]
        public void BasketReceiptTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            Assert.IsTrue(_basket.Receipt() == $"banana 7 0,44 {7*.44M}" ); // "banana 7 0,44 3,08"
        }
    }
}