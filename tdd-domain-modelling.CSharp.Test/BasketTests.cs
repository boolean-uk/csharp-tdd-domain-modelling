using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;


namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void AddItemTest()
        {
            //arange
            string itemname = "milk";
            int itemprice = 30;
            bool expected = true;
            Basket basket = new Basket();

            //act
            bool result = basket.add(itemname, itemprice);

            Assert.That(result == expected);
        }

        [Test]
        public void AddExistingItemTest()
        {
            //arange
            string itemname = "milk";
            int itemprice = 30;
            bool expected = false;

            Basket basket = new Basket();

            basket.add(itemname, itemprice);

            //act - adds the same item to the cart
            bool result = basket.add(itemname, itemprice);

            //asert
            Assert.That(result == expected);
        }

        [Test]
        public void TotalTest()
        {
            //arange
            string itemnameA = "milk";
            int itempriceA = 30;
            string itemnameB = "chocky milk";
            int itempriceB = 40;
            int expectedTotal = 70;

            Basket basket = new Basket();

            basket.add(itemnameA, itempriceA);
            basket.add(itemnameB, itempriceB);

            //act
            int total = basket.total();

            //assert
            Assert.That(total == expectedTotal);
        }

    }

}
