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

        private Shopper _shopper;

        [SetUp]
        public void SetUp()
        {
            _shopper = new Shopper(100);
        }

        [Test]
        [TestCase("Milk", 3)]
        [TestCase("Apple", 5)]
        [TestCase("Coffee", 10)]
        public void RestockTest(string name, float price)
        {
            Product product = new(name, price);
            _shopper.Basket.Add(product);
            _shopper.Restock();
            Assert.That(_shopper.Cupboard.Contains(product), Is.True);
            Assert.That(_shopper.Basket.Count, Is.EqualTo(0));
        }

        [Test]
        [TestCase("Milk", 3)]
        [TestCase("Apple", 5)]
        [TestCase("Coffee", 10)]
        public void AddTest(string name, float price)
        {
            Product product = new(name, price);
            _shopper.Add(product);
            Assert.That(_shopper.Basket.Contains(product), Is.True);
        }

        [Test]
        public void PayTest()
        {
            List<Product> products = new() 
            {
                new Product("Eggs", 10),
                new Product("Tea", 15),
                new Product("Milk", 5)
            };
            foreach (var product in products)
            {
                _shopper.Add(product);
            }
            _shopper.Pay();
            Assert.AreEqual(70, _shopper.Money);
        }

        [Test]
        public void TotalTest()
        {
            List<Product> products = new()
            {
                new Product("Eggs", 10),
                new Product("Tea", 15),
                new Product("Milk", 5),
                new Product("Coffe", 20)
            };
            foreach (var product in products)
            {
                _shopper.Add(product);
            }
            Assert.AreEqual(50, _shopper.Total());
        }

        [Test]
        public void ShopperFullScenarioTest()
        {
            List<Product> products = new()
            {
                new Product("Eggs", 10),
                new Product("Tea", 15),
                new Product("Milk", 5),
                new Product("Coffe", 20)
            };
            foreach (var product in products)
            {
                _shopper.Add(product);
            }
            Assert.AreEqual(50, _shopper.Total());
            
            _shopper.Pay();
            Assert.AreEqual(50, _shopper.Money);

            _shopper.Restock();
            foreach (var product in products)
            {
                Assert.That(_shopper.Cupboard.Contains(product));
            }           
        }
    }
}
