using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;


namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [TestCase("Bread", 0.99,  true)]
        [TestCase("Kinder Surprise", 0.99, false)]
        public void TestAdd(string item, decimal price, bool isItemPresent)
        {
            //arrange
            Basket basket = new Basket();

            basket.Add("Apple 100g", 2.49m);
            basket.Add("Carrot 100g", 1.99m);
            basket.Add("Kinder Surprise", 0.99m);
             

            //act
            bool result1 = basket.Add(item, price);

            //assert
            Assert.AreEqual(isItemPresent, result1);

        }
        [TestCase(9)]
        public void TestTotal(decimal expected)
        {
            //arrange
            Basket basket = new Basket();
            basket.Add("Apple 100g", 2);
            basket.Add("Carrot 100g", 3);
            basket.Add("Kinder Surprise", 4);
            //act
            decimal result = basket.Total();

            //assert
            Assert.IsTrue(result == expected);
        }
    }
}