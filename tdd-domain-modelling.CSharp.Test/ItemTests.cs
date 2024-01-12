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
    public class ItemTests
    {
        [TestCase("Potato", 1)]
        [TestCase("Apple", 2)]
        [TestCase("Banana", 2)]
        [TestCase("Coffee", 5)]
        [TestCase("Water", 3)]
        [TestCase("Chicken", 7)]
        [TestCase("Beef", 10)]
        public void TestItem(string name, int price)
        {
            Item item = new Item(name, price);

            Assert.That(item.Name, Is.EqualTo(name));
            Assert.That(item.Price, Is.EqualTo(price));
        }
    }
}
