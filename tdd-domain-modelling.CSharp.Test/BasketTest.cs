using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        private Basket? basket;
        [SetUp]
        public void Init()
        {
            basket = new Basket();
        }

        [TestCase("", 123f)]
        [TestCase("Test", 0f)]
        public void CreateItem(string name, float cost)
        {
            Item item = new Item(name, cost);
            Assert.That(item.ItemName, Is.EqualTo(name));
            Assert.That(item.Cost, Is.EqualTo(cost));
        }

        [TestCase("Test", 10f)]
        public void AddItem(string name, float cost)
        {
            Basket basket = new Basket();
            basket.AddItem(name, cost);
            Assert.That(basket.items.Count, Is.EqualTo(1));
        }

        [TestCase("Test", 10f)]
        [TestCase("Test", 0f)]
        [TestCase("Test", 1000f)]
        public void TotalCost(string name, float cost)
        {
            Basket basket = new Basket();
            basket.AddItem(name, cost);
            Assert.That(basket.TotalCost(), Is.EqualTo(cost));
        }

        [Test]
        public void EmptyReceipt()
        {
            List<string> expectedResult = new List<string>()
            {
                { "Total cost: 0"}
            };
            Basket basket = new Basket();
            Assert.That(basket.Receipt(), Is.EqualTo(expectedResult));
        }

        [Test]
        public void ReceiptWithItems()
        {
            List<string> expectedResult = new List<string>()
            {
                {"|Milk|10|x5"},
                {"|Chips|20|x1"},
                { "Total cost: 70"}
            };
            Basket basket = new Basket();
            for (int i = 0; i < 5; i++)
            {
                basket.AddItem("Milk", 10);
            }
            basket.AddItem("Chips", 20);
            Assert.That(basket.Receipt(), Is.EqualTo(expectedResult));
        }
    }
}