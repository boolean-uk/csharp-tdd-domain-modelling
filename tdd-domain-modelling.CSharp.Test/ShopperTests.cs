using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    internal class ShopperTests
    {
        [Test]
        [TestCase("Milk", 3)]
        [TestCase("Apple", 5)]
        [TestCase("Coffee", 10)]
        public void RestockTest(string name, float price)
        {
            Shopper shopper = new();
            Product product = new(name, price);
            shopper.Restock(product);
            Assert.That(shopper.Basket.Contains(product), Is.True);
        }
    }
}
