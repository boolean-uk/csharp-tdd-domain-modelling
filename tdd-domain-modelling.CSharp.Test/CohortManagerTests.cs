using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]

    public class BasketTest
    {
        Basket basket = null;

        [SetUp]
        public void SetUp()
        {
            this.basket = new Basket();
        }

        [Test]
        public void GettingPrice()
        {
            Assert.AreEqual(1f, basket.GetPrice("Apple"));
            Assert.AreEqual(2f, basket.GetPrice("Orange"));
            Assert.AreEqual(3f, basket.GetPrice("Banana"));
            Assert.AreEqual(4f, basket.GetPrice("Milk"));
            Assert.AreEqual(5f, basket.GetPrice("Bread"));
            Assert.AreEqual(0f, basket.GetPrice("NonExistentItem"));

        }

        [Test]

        public void AddingItems()
        {
            basket.AddItem("Apple", 1);
            Assert.AreEqual(1, basket.itemsInBasket["Apple"]);
            basket.AddItem("Apple", 1);
            Assert.AreEqual(2, basket.itemsInBasket["Apple"]);
            basket.AddItem("Orange", 1);
            Assert.AreEqual(1, basket.itemsInBasket["Orange"]);
            basket.AddItem("Banana", 1);
            Assert.AreEqual(1, basket.itemsInBasket["Banana"]);
            basket.AddItem("Milk", 1);
            Assert.AreEqual(1, basket.itemsInBasket["Milk"]);
            basket.AddItem("Bread", 1);
            Assert.AreEqual(1, basket.itemsInBasket["Bread"]);
            basket.AddItem("NonExistentItem", 1);
            Assert.AreEqual(0, basket.itemsInBasket["NonExistentItem"]);
        }

        [Test]

        public void RemovingItems()
        {
            basket.AddItem("Apple", 2);
            basket.RemoveItem("Apple", 1);
            Assert.AreEqual(1, basket.itemsInBasket["Apple"]);
            basket.AddItem("Orange", 1);
            basket.RemoveItem("Orange", 1);
            Assert.AreEqual(0, basket.itemsInBasket["Orange"]);
        }

        [Test]

        public void GettingTotalCost()
        {
            basket.AddItem("Apple", 1);
            basket.AddItem("Orange", 1);
            basket.AddItem("Banana", 1);
            basket.AddItem("Milk", 1);
            basket.AddItem("Bread", 1);
            Assert.AreEqual(15f, basket.GetTotalCost());
        }
    }
}