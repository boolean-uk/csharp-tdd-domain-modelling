using NUnit.Framework;
using System.Xml.Linq;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class ShoppingListTest
    {
        [Test]


        public void CheckTotalCostInBasket()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.AddToShoppingCart("banana", 1);

            // assert
            Assert.IsTrue(1 == basket.Total);
        }

        [Test]
        public void TestReceipt()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.AddToShoppingCart("banana", 1);
            basket.AddToShoppingCart("carrot", 2);

            // assert
            string receipt = basket.Receipt();

            Assert.IsTrue(receipt == "(banana:1)(carrot:2)-Total(3)");

        }
    }
}