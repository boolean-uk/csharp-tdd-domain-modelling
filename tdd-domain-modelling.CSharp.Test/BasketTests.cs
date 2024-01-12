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

        [TestCase("Apples", 3, true)]
        [TestCase("Bread", 4, true)]
        public void AddTest1(string s, int i, bool expected)
        {
            //  Arrange - set up test values
            Basket basket = new Basket();


            //  Act - use the fucntion we want to test
            bool result = basket.Add(s, i);

            //  Assert - check the results
            Assert.True(result);

        }

        [TestCase("Apples", 2, false)]
        [TestCase("Bread", 4, false)]
        public void AddTest2(string s, int i, bool expected)
        {
            //  Arrange - set up test values
            Basket basket = new Basket();

            //  Act - use the fucntion we want to test
            basket.Add(s, i);
            bool result = basket.Add(s, i);

            //  Assert - check the results
            Assert.IsTrue(result == expected);

        }

        [Test]
        public void TotalTest()
        {
            //  Arrange - set up test values
            Basket basket = new Basket();
            basket.Add("Apple", 3);
            basket.Add("Bread", 4);


            //  Act - use the fucntion we want to test
            int result = basket.Total();

            //  Assert - check the results
            Assert.That(result, Is.EqualTo(7));

        }
    }
}
