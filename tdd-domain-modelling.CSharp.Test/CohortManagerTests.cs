using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        CohortManager manager;

        [SetUp]
        public void SetUp()
        {
            manager = new CohortManager();
        }

        [Test]
        public void AddingItemsToBasket()
        {
            bool result = manager.add("Cheese", 30);
            bool result2 = manager.add("Ham", 40);

            Assert.IsTrue(result2);
        }

        [Test]
        public void AddingDoubleItemsToBasket()
        {
            bool result = manager.add("Cheese", 30);
            bool result2 = manager.add("Cheese", 40);

            Assert.IsFalse(result2);
        }

        [Test]
        public void TestingTotalValue()
        {
            manager.add("Ham", 40);
            manager.add("Cheese", 30);
            manager.add("Milk", 50);
            int totalCost = manager.total();

            Assert.That(120, Is.EqualTo(totalCost));
        }

        [Test]
        public void TestingTotalDoubles()
        {
            manager.add("Ham", 40);
            manager.add("Ham", 30);
            manager.add("Milk", 50);
            int totalCost = manager.total();

            Assert.That(90, Is.EqualTo(totalCost));
        }
    }
}