using NUnit.Framework;
using System.Xml.Linq;
using tdd_domain_modelling.CSharp.Main;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tdd_domain_modelling.CSharp.Tests
{
    public class BasketTests
    {

        [Test]
        public void testAdd()
        {
            //Arrange
            Basket basket = new Basket();

            //Act
            bool result = basket.add("shampoo", 5);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void testAddExisting()
        {
            //Arrange
            Basket basket = new Basket();

            //Act
            basket.add("shampoo", 5);
            basket.add("entrecote", 10);
            bool result = basket.add("shampoo", 5);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void testTotalShouldBe15()
        {

            //Arrange
            Basket basket = new Basket();
            basket.add("shampoo", 5);
            basket.add("entrecote", 10);

            //Act
            int result = basket.basketTotal();

            //Assert
            Assert.That(result, Is.EqualTo(15));

        }
    }
}
