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
    public class BasketTest
    {
        [Test]
        public void TestBasketInitialization()
        {
            Basket basket = new Basket();

            Assert.That(basket.Items.Count, Is.EqualTo(0));
        }

        [TestCase("Apple", 2)]
        [TestCase("Pie", 4)]
        [TestCase("Carrot", 3)]
        [TestCase("Water", 3)]
        public void TestBasketAdd(string name, int price)
        {
            Basket basket = new Basket();
            Item item = new Item(name, price);
            basket.Add(item);

            Assert.That(basket.Items.Count, Is.EqualTo(1));
            Assert.True(basket.Items.Contains(item));
        }

        [Test]
        public void TestMultipleAdd()
        {
            Basket basket = new Basket();
            Item item1 = new Item("apple", 2);
            Item item2 = new Item("water", 3);
            Item item3 = new Item("pie", 4);

            basket.Add(item1);
            basket.Add(item2);
            basket.Add(item3);

            Assert.That(basket.Items.Count, Is.EqualTo(3));
            Assert.True(basket.Items.Contains(item1));
            Assert.True(basket.Items.Contains(item2));
            Assert.True(basket.Items.Contains(item3));
        }

        [TestCase("apple", 2)]
        public void TestTotal(string name, int price)
        {
            Basket basket = new Basket();
            Item item = new Item(name, price);
            basket.Add(item);

            Assert.That(basket.Total(), Is.EqualTo(price));
        }

        [Test]
        public void TestMultipleTotal()
        {
            Basket basket = new Basket();
            Item item = new Item("Apple", 2);
            Item item2 = new Item("Water", 4);
            Item item3 = new Item("Chicken", 7);

            basket.Add(item);
            basket.Add(item2);
            basket.Add(item3);

            Assert.That(basket.Total(), Is.EqualTo(13));
        }

    }
}
