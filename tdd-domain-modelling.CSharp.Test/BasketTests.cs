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
    public class BasketTests
    {
        [Test]
        public void addBasketItem()
        {
            //Arrange
            Basket basket = new Basket();

            //Act


            //Assess
            Assert.True(basket.add("apple", 4)); 


        }
        [Test]
        public void addDuplicate()
        {
            //Arrange
            Basket basket = new Basket();

            //Act
            basket.add("apple", 4);

            //Assess
            Assert.False(basket.add("apple", 4));


        }
        [Test]
        public void findTotal()
        {
            //Arrange
            Basket basket = new Basket();

            //Act
            basket.add("apple", 4);
            basket.add("orange", 3);

            //Assess
            Assert.AreEqual(basket.total(), 7);


        }
    }
}
