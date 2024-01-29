using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {

        [Test]
        public void TestReturnTrueIfItemIsNotInBasket()
        {
            Basket basket = new Basket();
            basket._items.Add("Milk", 2);
            Assert.IsTrue(basket.AddItem("Eggs", 6));
        }

        [Test]
        public void TestReturnFalseIfItemIsInBasket()
        {
            Basket basket = new Basket();
            basket._items.Add("Milk", 2);
            Assert.IsFalse(basket.AddItem("Milk", 5));
        }

        [Test]
        public void TestIfItemWasAdded()
        {
            Basket basket = new Basket();
            basket.AddItem("Milk", 2);
            Assert.IsTrue(basket._items.ContainsKey("Milk"));
        }

        [Test]
        public void TestTotalCostOfBasket()
        {
            Basket basket = new Basket();
            basket._items.Add("Milk", 2);
            basket._items.Add("Eggs", 1);
            Assert.AreEqual(3, basket.Total());
        }

    }
}