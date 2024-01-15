using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTests
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void AddItemToBasket()
        {
            // Arrange
            Basket basket = new Basket();

            // Act
            basket.Add("Bread", 10);

            // Assert
            Assert.IsTrue(basket.items.ContainsKey("Bread"));
            Assert.AreEqual(10, basket.items["Bread"]);
        }

        [Test]
        public void AddExistingItemToBasket()
        {
            // Arrange
            Basket basket = new Basket();

            // Act
            basket.Add("Bread", 10);

            // Assert
            Assert.Throws<Exception>(() => basket.Add("Bread", 15));
        }

    }
}
