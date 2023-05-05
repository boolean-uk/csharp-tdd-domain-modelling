using tdd_domain_modelling.CSharp.Main;
using NUnit.Framework;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTest
    {
        private Basket _basket;
        private Basket _pricelist;
        public BasketTest()
        {
            _basket = new Basket();
            _pricelist = new Basket();
        }

        // Item with the provided name *is not* already in the basket
        // Should return true and pass the test
        [TestCase("peach", 3)]
        public void NotInBasket(string newproduct, int amount)
        {
            Assert.IsTrue(_basket.addToBasket(newproduct, amount));
        }

        // Item with the provided name *is* already in the basket
        // Should return false and fail the test
        [TestCase("apple", 3)]
        public void InBasket(string newproduct, int amount)
        {
            Assert.IsFalse(_basket.addToBasket(newproduct, amount));
        }

        // Item with the provided name *is not* already in the basket
        // Should return true and pass the test
        [TestCase("peach", 1.50)]
        public void NotInPricelist(string newproduct, decimal price)
        {
            Assert.IsTrue(_pricelist.addToPricelist(newproduct, price));
        }

        // Item with the provided name *is* already in the basket
        // Should return false and fail the test
        [TestCase("apple", 1)]
        public void InPricelist(string newproduct, decimal price)
        {
            Assert.IsFalse(_pricelist.addToPricelist(newproduct, price));
        }

        // The total cost *is* the total amount of the product prices in the basket
        // Should return *totalamount* and pass the test
        [Test]
        public void TotalCost()
        {
            Assert.AreEqual(9m, _pricelist.total());
        }
    }
}