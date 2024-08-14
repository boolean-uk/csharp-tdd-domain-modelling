using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class SupermarketTests
    {
        [Test]
        public void AddCupboardsTests()
        {
            //arrange
            Basket basket = new Basket();
            string name = "Cupboard";
            int price = 12;
            bool expected = true;

            //act
            bool result = basket.Add(name, price);

            //assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AddDuplicateCupboardsTests()
        {
            //arrange
            Basket basket = new Basket();
            string name = "Cupboard";
            int price = 12;
            bool expected = false;

            //act
            basket.Add(name, price);
            bool result = basket.Add(name, price);

            //assert
            Assert.That(result, Is.EqualTo((bool)expected));
        }

        [Test]
        public void TotalCostTest()
        {
            //arrange
            Basket basket = new Basket();
            string name1 = "Coffee Mug";
            int price1 = 8;
            string name2 = "Cupboard";
            int price2 = 12;
            string name3 = "Cat Food";
            int price3 = 20;
            int expected = 40;

            //act
            basket.Add(name1, price1);
            basket.Add(name2, price2);
            basket.Add(name3, price3);
            int result = basket.Total();

            //assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}