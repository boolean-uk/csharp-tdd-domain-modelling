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

        }
    }
}