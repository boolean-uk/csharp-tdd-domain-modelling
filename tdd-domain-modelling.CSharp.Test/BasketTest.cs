using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
   [TestFixture]
    
    internal class BasketTest {

        [SetUp] public void setup()
        {
            Basket basket = new Basket();
            int[] prices = { 52, 321, 3213, 432 };
            string[] existingItems = { " ", "Brunost", "smultring", "milk" };

            for (int i = 0; i < existingItems.Length; i++)
            {

                basket.add(existingItems[i], prices[i]);
            }
        }





        [TestCase("Brunost",43)]
        [TestCase("Milk", 234)]
        [TestCase("Pizza", 323)]
        [TestCase("Sodapop", 23)]
        [TestCase("Cheesecrackers", 433)]
        public void addItemToBasket(string productName, int price)
        {
            Basket basket = new Basket();
            int[] prices = { 52, 321, 3213, 432 };
            string[] existingItems = { " ", "Brunost", "smultring", "milk" };

            for (int i = 0; i < existingItems.Length; i++)
            {

                basket.add(existingItems[i], prices[i]);
            }
            bool result = basket.add(productName,price);
            bool exists = existingItems.Contains(productName);

            //Assert
            Assert.IsFalse(result == exists);
        }
        [Test]
        public void getTotal() {
            Basket basket = new Basket();
            int[] prices = { 52, 321, 3213, 432 };
            string[] existingItems = { " ", "Brunost", "smultring", "milk" };

            for (int i = 0; i < existingItems.Length; i++)
            {
                basket.add(existingItems[i], prices[i]);
            }
            int sum = prices.Sum();

            int result = basket.total();

            Assert.IsTrue(result > 0);
            Assert.AreEqual(sum, result);
        
        
        }

       
    }
}

