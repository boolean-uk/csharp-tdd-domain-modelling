using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTests
    {
        [Test]
        public void SecondTest()
        {

            Basket basket = new Basket();
        }


        [TestCase("apple", 10)]
        [TestCase("Orange", 5)]
        public void Add(string item, int price)
        {
            //arrange
            Basket basket = new Basket();

            //act
            Dictionary<string, int> items = basket.Add(item, price);

            //assert
             Assert.IsTrue(items.ContainsKey(item));
        }

        [TestCase("apple", 10)]
        [TestCase("Orange", 5)]
        public void BooleanAddTest(string item, int price)
        {
            //arrange
            Basket basket = new Basket();

            //act
            Dictionary<string, int> items = basket.Add(item, price);

            //assert
            Assert.IsTrue(items.ContainsKey(item));
        }

        [Test]
        public void total() 
        {
            //arrange 
            Basket basket = new Basket();
            basket.Add("apple", 10);
            basket.Add("bana", 5);
            //act 
            int result = basket.sum();

            //assert
            Assert.IsTrue(result == 15);
        }
        

       
    }
}
