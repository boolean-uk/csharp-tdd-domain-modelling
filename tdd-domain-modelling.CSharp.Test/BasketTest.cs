using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    internal class BasketTest




    {

        Basket basket;
        [SetUp]
        public void setup()
        {
            basket = new Basket();
        }
        [Test]

        public void CanAddItemsToBasket()
        {
            bool result = basket.Add("Milk", 12);

            Assert.That(result, Is.EqualTo(true));
            Assert.That(basket.items.Count, Is.EqualTo(1));


        }

        [Test]

        public void CantAddDuplicates()
        {
            bool firstAdd = basket.Add("Milk", 12);
            bool secondAdd = basket.Add("Milk", 12);


            Assert.That(firstAdd, Is.EqualTo(true));
            Assert.That(secondAdd, Is.EqualTo(false));
            Assert.That(basket.items.Count, Is.EqualTo(1));


        }

        [Test]
        
        public void GetTotCostOfItemsToBasket() {

            basket.Add("Milk", 12);
            basket.Add("Bread", 6);
            basket.Add("Butter", 102);

            Assert.That(basket.total(), Is.EqualTo(12+6+102));

        }


    }
}
