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
        public void AddProduct()
        {

            bool addres = basket.add("A", 1);

            Assert.AreEqual(1, basket.basketitems());
            Assert.IsTrue(addres);

        }

        [Test]
        public void RemoveProduct()
        {
            bool addres = basket.add("A", 1);
            bool addres2 = basket.add("B", 2);

            Assert.AreEqual(2, basket.basketitems());

            basket.remove("A");

            Assert.AreEqual(1, basket.basketitems());

            bool nonremovable = basket.remove("C");

            Assert.IsFalse(nonremovable);

        }

        [Test]
        public void NoDuplicates()
        {

            bool addres = basket.add("A", 1);
            bool addres2 = basket.add("A", 1);

            Assert.AreEqual(1, basket.basketitems());
            Assert.IsTrue(addres);
            Assert.IsFalse(addres2);

        }

        [Test]
        public void Total()
        {

            basket.add("A", 1);
            basket.add("B", 2);

            Assert.AreEqual(3, basket.total());

        }


    }
}