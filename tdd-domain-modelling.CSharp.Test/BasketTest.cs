using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        [TestCase("Cheese", 60)]
        [TestCase("Milk", 10)]
        [TestCase("Eggs", 30)]
        [TestCase("Potatoes", 15)]
        [TestCase("Onions", 20)]
        public void testAddToBasket(string item, int price)
        {
            //Setup
            Basket basket = new Basket();
            //Execute
            basket.addItem(item, price);
            //Verify, if the item in the dictionary with the provided key has the same price as the given item it has been properly added.
            Assert.That(basket.items[item].Equals(price));
        }
    }
}
