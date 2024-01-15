using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void BasketAddItem()
        {
            //arrange
            Basket basket = new Basket();
            string product = "Deodorant";
            int price = 100;

            //act
            basket.Add(product, price);

            //assert
            Assert.That(basket.Contains(product), Is.True);

        }

        [Test]
        public void BasketSumItems() 
        {
            //arrange
            Basket basket = new Basket();
            basket.Add("Deodorant", 100);
            basket.Add("Deodorant", 100);
            basket.Add("Cat", 50.50);

            //act
            double sum = basket.Sum();

            //assert
            Assert.That(sum, Is.EqualTo(250.50));
        }
    }
}
