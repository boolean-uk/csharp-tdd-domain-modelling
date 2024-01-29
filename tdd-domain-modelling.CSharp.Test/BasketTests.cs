using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        private Basket _basket;

        [SetUp]
        public void Setup()
        {
            _basket = new Basket();
            _basket._items.Add("Milk", 2);
        }

        [Test]
        public void TestReturnTrueIfItemIsNotInBasket()
        {
            Assert.IsTrue(_basket.AddItem("Eggs", 6));
        }

        [Test]
        public void TestReturnFalseIfItemIsInBasket()
        {
            Assert.IsFalse(_basket.AddItem("Milk", 5));
        }

        [Test]
        public void TestIfItemWasAdded()
        {
            Assert.IsTrue(_basket._items.ContainsKey("Milk"));
        }

        [Test]
        public void TestTotalCostOfBasket()
        {
            _basket._items.Add("Eggs", 1);
            Assert.AreEqual(3, _basket.Total());
        }

    }
}