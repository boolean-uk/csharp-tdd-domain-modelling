using NUnit.Framework;
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using tdd_domain_modelling.CSharp.Main;
using static tdd_domain_modelling.CSharp.Main.Basket;
//using NUnit.Framework.Legacy;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {

        [Test]
        public void BasketSum()
        {
            //arrange
            //instance a new basket
            Basket basket = new Basket();
            
            //add items to basket (new items are created when adding)
            //AddToBasket(item,price,quantity)`
            basket.AddToBasket("Cucumber", 1.99F, 1);
            basket.AddToBasket("Bread", 2.50F, 2);
            basket.AddToBasket("Bread", 1.50F, 1);
            float expected = (1.99F * 1) + (2.50F *2) + (1.50F * 1);

            //act
            float result = basket.CheckoutSum();

            //assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestReceipt()
        {
            //arrange
            Basket basket = new Basket();
            //AddToBasket(item,price,quantity)`
            basket.AddToBasket("Cucumber", 1.99F, 1);
            basket.AddToBasket("Bread", 2.50F, 2);
            float totalCost = 1.99F + (2.50F * 2);

            //act
            string myReceipt = basket.GetReceipt();

            //assert
            //Assert.IsTrue(basket.myBasket.Count != 0); //passes -> the items are put in the basket
            Assert.IsTrue(myReceipt.Contains($"Total {totalCost}"));
        }

    }
}