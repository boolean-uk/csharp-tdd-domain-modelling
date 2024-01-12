using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    [TestFixture]
    public class BasketTest
{
        [Test]
        public void AddTest()
        {
            var basket = new Basket();
            string item1 = "six-pack of apples";
            int price1 = 65;
            string item2 = "Lego Death Star";
            int price2 = 7899;

            basket.Add(item2, price2);


            Assert.That(price2 == basket._shoppingBasket[item2] , Is.True);
        }

        [Test]
        public void TotalTest()
        {
            var basket = new Basket();
            string item1 = "six-pack of apples";
            int price1 = 65;
            string item2 = "Lego Death Star";
            int price2 = 7899;

            basket.Add(item1, price1);
            basket.Add(item2, price2);


            Assert.That(price2 == basket._shoppingBasket[item2], Is.True);
            Assert.That(basket._shoppingBasket.ContainsKey(item1), Is.True);
            Assert.AreEqual(basket.Total(), 7964);
        }



    }
}
