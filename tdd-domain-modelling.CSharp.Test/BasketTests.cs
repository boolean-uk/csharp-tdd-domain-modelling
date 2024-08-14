using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

//based tests on the domain model provided in exercice2.md
namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class BasketTest
    {
        [Test]
        public void addItemforFirstTimeTest()
        {
            Basket b = new Basket();

            bool added = b.add("apple", 10);

            Assert.That(added);
        }

        [Test]
        public void addItemAlreadyInBasketTest()
        {
            Basket b = new Basket();

            b.add("apple", 10);
            bool added = b.add("apple", 10);

            Assert.That(!added);
        
        }

        [Test]
        public void totalSumTest1()
        {
            Basket b = new Basket();
            int expected = 70;

            b.add("apple", 10);
            b.add("coco pops", 40);
            b.add("baking soda", 20);

            int totalSum = b.total();

            Assert.That(totalSum == expected);
        }

        [Test]
        public void totalSumTest2()
        {
            Basket b = new Basket();
            int expected = 70;

            b.add("apple", 10);
            b.add("coco pops", 40);
            b.add("coco pops", 40);
            b.add("baking soda", 20);

            int totalSum = b.total();

            Assert.AreEqual(totalSum, expected);
        }
    }
}