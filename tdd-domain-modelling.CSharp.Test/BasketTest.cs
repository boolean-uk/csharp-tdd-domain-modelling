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
        [Test]
        public void AddItem()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.add("Apples", 2);

            // assert
            Assert.IsTrue(basket.basket.Count == 1);
        }

        [Test]
        public void AddSameItems()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.add("Apples", 2);
            basket.add("Apples", 2);


            // assert
            Assert.IsTrue(basket.basket.Count == 1);
        }

        [Test]
        public void AddDifferentItems()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.add("Apples", 2);
            basket.add("Banana", 3);


            // assert
            Assert.IsTrue(basket.basket.Count == 2);
        }

        [Test]
        public void AddMultipleSameItem()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.add("Apples", 2);
            basket.add("Apples", 2);


            // assert
            Assert.IsTrue(basket.basket["Apples"].Amount == 2);
        }

        [Test]
        public void AddReturnTrue()
        {
            // arrange
            Basket basket = new Basket();

            // act


            // assert
            Assert.IsTrue(basket.add("Apples", 2));
        }

        [Test]
        public void AddReturnFalse()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.add("Apples", 2);


            // assert
            Assert.IsFalse(basket.add("Apples", 2));
        }

        [Test]
        public void totalCheckSum()
        {
            // arrange
            Basket basket = new Basket();

            // act
            basket.add("Apples", 2);
            basket.add("Apples", 2);
            basket.add("Banana", 3);


            // assert
            Assert.IsTrue(basket.total() == 7);
        }
    }
}
