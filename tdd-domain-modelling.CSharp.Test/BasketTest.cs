using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {


        [Test]
        public void Add_NewItemToBasket()
        {
            Basket basket = new Basket();
            bool result = basket.AddProduct("Milk", 2); // Adding 2 units of Milk to the basket
            Assert.IsTrue(result);
        }


        [Test]
        public void Add_ExistingItemToBasket()
        {
            Basket basket = new Basket();
            basket.AddProduct("Bread", 3); // Adding 3 units of Bread to the basket initially
            bool result = basket.AddProduct("Bread", 1); // Trying to add more Bread to the basket
            Assert.IsFalse(result);
        }

        [Test]
        public void CalculateTotal_Total()
        {
            // Arrange
            Basket basket = new Basket();
            basket.AddProduct("Apple", 2);
            basket.AddProduct("Banana", 3);

            // Act
            int total = basket.CalculateTotal();

            // Assert
            Assert.AreEqual(5, total);
        }
    }
}
