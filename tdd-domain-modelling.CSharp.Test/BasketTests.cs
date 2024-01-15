using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTests
    {
        [Test]
        public void FirstTest()
        {
            Basket basket = new Basket();

            bool addTest = basket.addItem("Milk", 3);
            
            Assert.IsTrue(addTest);
        }
        [Test]
        public void SecondTest()
        {
            Basket basket = new Basket();

            basket.addItem("Milk", 3);
            bool addTest = basket.addItem("Milk", 3);
            
            Assert.IsFalse(addTest);

        }
        [Test]
        public void ThirdTest()
        {
            Basket basket = new Basket();

            basket.addItem("Milk", 3);

            Assert.IsTrue(basket.totalCost() == 3);
        }
        [Test]
        public void FourthTest()
        {
            Basket basket = new Basket();
            basket.addItem("Milk", 3);
            basket.addItem("Flour", 2);
            basket.addItem("Egg", 5);

            Assert.IsTrue(basket.totalCost() == 10);
        }
        [Test]
        public void FifthTest()
        {
            Basket basket = new Basket();
            basket.addItem("Milk", 3);
            basket.addItem("Milk", 3);
            Assert.IsTrue(basket.totalCost() == 3);
        }

    }
}