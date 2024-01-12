using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Test
{
    public class Tests
    {
        [TestFixture]
        public class Exercise2Tests
        {
            [SetUp]
            public void Setup() 
            { 

            }

            [Test]
            public void AddProductTest() 
            {
                // Arrange
                Basket basket = new Basket();
                string productName = "Bread";
                int productPrice = 20;

                // Act
                bool res = basket.add(productName, productPrice);

                // Assert
                Assert.That(true, Is.EqualTo(res));
            }

            [Test]
            public void CheckBasketTotalPrice()
            {
                // Arrange
                Basket basket = new Basket();
                string product1N = "Shampoo";
                int product1P = 20;

                string product2N = "Tomato";
                int product2P = 10;

                string product3N = "Milk";
                int product3P = 18;

                int totalPrice = product1P + product2P + product3P;
                // Act
                basket.add(product1N, product1P);
                basket.add(product2N, product2P);
                basket.add(product3N, product3P);

                int value = basket.total();
                // Assert
                Assert.That(totalPrice, Is.EqualTo(value));
            }
        }
    }
}