using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTest
    {
        private Basket _basket;
        private Basket _prices;
        public BasketTest()
        {
            _basket = new Basket();
            _prices = new Basket();
        }


        //checking if product is in a basket
        [TestCase ("cheese", 2)]
        public void InBasketTest(string name, int quantity)
        {
            Assert.IsFalse(_basket.addToBasket(name, quantity));
        }

        [TestCase("cider", 1)]
        public void NotInBasketTest(string name, int quantity)
        {
            Assert.IsTrue(_basket.addToBasket(name, quantity));
        }

        //checking a product price
        [TestCase("paprika", 0.99)]
        public void IsPrice(string product, decimal price)
        {
            Assert.IsFalse(_basket.addToPrice(product, price));
        }
        [TestCase("beer", 3.99)]
        public void NotAPrice(string product, decimal price)
        {
            Assert.IsTrue(_basket.addToPrice(product, price));
        }

        //check the total price
        [Test]
        public void Receipt()
        {
            Assert.AreEqual(24.42m, _prices.total());
        }
    }
}


