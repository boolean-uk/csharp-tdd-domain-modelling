using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class ShopperTest2
    {
        Shopper shopper = null;

        [SetUp]
        public void SetUp()
        {
            this.shopper = new Shopper();
        }

        [Test]
        public void AddProduct()
        {

            Product pro = new Product("B", 2, 3);

            shopper.AddProduct(pro);
            Assert.That(shopper._basket.Count, Is.EqualTo(1));

            shopper.AddProduct(pro);
            Assert.That(shopper._basket.Count, Is.EqualTo(1));

        }

        [Test]
        public void ProductSum()
        {

            Product pro1 = new Product("B", 2, 3);
            Product pro2 = new Product("A", 5, 2);
            shopper.AddProduct(pro1);
            shopper.AddProduct(pro2);

            int pr = shopper.BasketPrice();

            Assert.That(pr, Is.EqualTo(7));

        }

        [Test]
        public void ProductListing()
        {

            Product pro1 = new Product("B", 2, 3);
            Product pro2 = new Product("A", 5, 2);
            Product pro3 = new Product("G", 4, 6);
            shopper.AddProduct(pro1);
            shopper.AddProduct(pro2);
            shopper.AddProduct(pro3);

            List<Product> tester = new List<Product> { pro1, pro2, pro3 };

            Assert.That(shopper._basket, Is.EqualTo(tester));

        }
    }
}