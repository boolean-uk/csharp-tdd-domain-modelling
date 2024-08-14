using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketTests
    {
        [Test]
        public void AddTest()
        {
            // arrange
            Basket basket = new();
            string product = "Pear";
            int price = 10;
            // act
            var result = basket.Add(product, price);
            // assert
            Assert.True(result);
        }
        [Test]
        public void AddSeveralTest()
        {
            // arrange
            Basket basket = new();
            string product1 = "Pear";
            int price1 = 10;
            string product2 = "Coffee";
            int price2 = 55;
            // act
            var result1 = basket.Add(product1, price1);
            var result2 = basket.Add(product2, price2);

            // assert
            Assert.True(result1);
            Assert.True(result2);

        }

        [Test]
        public void AddConflictingTest()
        {
            // arrange
            Basket basket = new();
            string product = "Pear";
            int price = 10;
            // act
            var result1 = basket.Add(product, price);
            var result2 = basket.Add(product, price);

            // assert
            Assert.True(result1);
            Assert.False(result2);
        }

        [Test]
        public void TotalZeroItemsTest()
        {
            Basket basket = new();

            int result = basket.Total();
            int expectedResult = 0;

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void TotalOneItemTest()
        {
            // arrange
            Basket basket = new();
            string product = "Pear";
            int price = 10;
            // act
            basket.Add(product, price);
            var result = basket.Total();
            int expectedResult = price;

            Assert.AreEqual(expectedResult, result);

        }

        [Test]
        public void TotalSeveralItemsTest()
        {
            // arrange
            Basket basket = new();
            string product1 = "Pear";
            int price1 = 10;
            string product2 = "Coffee";
            int price2 = 55;
            // act
            basket.Add(product1, price1);
            basket.Add(product2, price2);

            var result = basket.Total();
            int expectedResult = price1 + price2;

            Assert.AreEqual(expectedResult, result);

        }
    }
}
