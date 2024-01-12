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
            shopper.Basket.Add(product);
            shopper.Restock();
            Assert.That(shopper.Cupboard.Contains(product), Is.True);
        }

        [Test]
        [TestCase("Milk", 3)]
        [TestCase("Apple", 5)]
        [TestCase("Coffee", 10)]
        public void AddTest(string name, float price)
        {
            Shopper shopper = new();
            Product product = new(name, price);
            shopper.Add(product);
            Assert.That(shopper.Basket.Contains(product), Is.True);
        }
    }
}
