using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    internal class BasketTests
    {
        [Test]
        public void AddTest()
        {
            //arrange
            Basket shopper = new Basket();
            Dictionary<string, int> basket = new Dictionary<string, int>();

            //act
            shopper.Add(basket, "cake", 2);

            //assert
            Assert.IsTrue(basket["cake"]== 2);
        }


        [Test]
        public void FinalTest()
        {
            //arrange
            Basket shopper = new Basket();
            Dictionary<string, int> basket = new Dictionary<string, int>();
            int sumofbasket;

            //act
            shopper.Add(basket, "cake", 2);
            shopper.Add(basket, "chocolate", 3);
            int expected = 5;
            sumofbasket =shopper.Sum(basket);

            //assert
            Assert.IsTrue(expected == sumofbasket);
        }
    }
}
