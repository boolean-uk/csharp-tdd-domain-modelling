using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class SupermarketTests
    {
        [TestCase("Milk", 15)]
        public void BasketTrueTest(String product, int price)
        {
            Basket basket = new Basket();
            bool added = basket.add(product, price);
            Assert.That(added == true);
        }

        [TestCase("Bread", 10)]
        public void BasketFalseTest(String product, int price)
        {
            Basket basket = new Basket();
            basket.add(product, price);
            bool added = basket.add(product, price);
            Assert.That(added == false);
        }

        [Test]
        public void TotalCostTest()
        {
            Basket basket = new Basket();
            basket.add("Bread", 10);
            basket.add("Milk", 15);
            int total = basket.total();
            Assert.That(total == 25);
        }
    }
}
