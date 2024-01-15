using NUnit.Framework;
using td_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    public class BasketClassTests
    {
        [Test]
        public void shouldAddProductToBasket()
        {
            // Setup
            Basket b = new Basket();

            // Execute
            bool added = b.Add("Coca cola", 22);
            
            // Verify
            Assert.That(added, Is.True);
            Assert.That(b.items != null, Is.True);
        }

        [Test]
        public void shouldReturnPriceForProductsInBasket()
        {
            // Setup
            Basket b = new Basket();
            b.Add("Coca cola", 22);
            b.Add("Urge", 22);

            //Execute
            int sum = b.Total();

            // Verify
            Assert.That(sum == 44);
        }
    }

}
