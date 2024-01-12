using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class SecondTest
{
        [Test]
        public void Add_NewItemToBasket_ReturnsTrue()
        {
            // Arrange
            Basket basket = new Basket();

            // Act
            bool result = basket.add("Milk", 2); // Adding 2 units of Milk to the basket

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Add_ExistingItemToBasket_ReturnsFalse()
        {
            // Arrange
            Basket basket = new Basket();
            basket.add("Bread", 1); // Adding 1 unit of Bread to the basket

            // Act
            bool result = basket.add("Bread", 1); // Attempting to add Bread again

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Total_CalculateTotalCost_ReturnsCorrectTotal()
        {
            // Arrange
            Basket basket = new Basket();
            basket.add("Apple", 3); // Adding 3 units of Apple to the basket
            basket.add("Banana", 2); // Adding 2 units of Banana to the basket

            // Act
            int total = basket.Total();

            // Assert
            Assert.AreEqual(5, total); // 3 * Apple price + 2 * Banana price = 5
        }
    }
}
