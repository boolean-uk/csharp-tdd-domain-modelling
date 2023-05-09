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
        public void BasketTotalAddMultipleProductsTest() 
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            _basket.AddProduct("toothpaste", 2);
            _basket.AddProduct("apple", 3);
            Assert.IsTrue(_basket.Basket["banana"] == 7);
            Assert.IsTrue(_basket.Basket["toothpaste"] == 2);
            Assert.IsTrue(_basket.Basket["apple"] == 3);
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
        public void BasketTotalRemoveMultipleProductsTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            _basket.RemoveProduct("banana", 1);
            _basket.AddProduct("toothpaste", 2);
            _basket.RemoveProduct("toothpaste", 2);
            _basket.AddProduct("apple", 3);
            _basket.RemoveProduct("apple", 2);
            Assert.IsTrue(_basket.Basket["banana"] == 6);
            Assert.IsFalse(_basket.Basket.ContainsKey("cleaner"));
            Assert.IsFalse(_basket.Basket.ContainsKey("toothpaste"));
            Assert.IsTrue(_basket.Basket["apple"] == 1);

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
        public void BasketTotalCostMultipleProductsTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            _basket.AddProduct("toothpaste", 2);
            Assert.AreEqual(_basket.Total(), 7 * 0.44M + 2 * 2.19M);
        }

        [Test]
        public void BasketReceiptTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            Assert.IsTrue(_basket.Receipt() == $"banana 7 0,44 {7*.44M} {Environment.NewLine} " ); // "banana 7 0,44 3,08"
        }
        [Test]
        public void BasketReceiptMultipleProductsTest()
        {
            ShoppingBasket _basket = new ShoppingBasket();
            _basket.AddProduct("banana", 7);
            _basket.AddProduct("toothpaste", 2);
            Assert.IsTrue(_basket.Receipt() == $"banana 7 0,44 {7*.44M} {Environment.NewLine} toothpaste 2 2,19 {2 * 2.19M} {Environment.NewLine} ");
        }
    }
}