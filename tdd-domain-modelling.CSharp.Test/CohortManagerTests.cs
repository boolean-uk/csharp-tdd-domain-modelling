using NUnit.Framework;
using System.Diagnostics;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class CohortManagerTest
    {
        // 1. Create Test/Assert that fails or does not build.
        // 2. Updated code untill test passes.
        // 3. Go to step 1.
        [Test]
        public void Add()
        {
            CohortManager core = new CohortManager();

            Basket basket = new Basket();
            Assert.That(basket, Is.Not.Null, "Basket should be created successfully.");

            bool succsess = basket.Add("Pack of Gum", 20);
            Assert.That(succsess, Is.True, "Adding item should be succsessful.");

            succsess = basket.Add("Pack of Gum", 20);
            Assert.That(succsess, Is.False, "Adding item again suld be unsuccsessful.");

            Assert.That(basket.Items.ContainsKey("Pack of Gum"), Is.True, "Product should be in basket");
        }
        [Test]
        public void Total()
        {
            CohortManager core = new CohortManager();
            Basket basket = new Basket();
            bool succsess = basket.Add("Pack of Gum", 20);

            int totalPrice = basket.Total();
            Assert.That((totalPrice), Is.EqualTo(20), "Price should be equal to cost of item in basket");

            succsess = basket.Add("Apple", 7);
            totalPrice = basket.Total();

            Assert.That((totalPrice), Is.EqualTo(27), "Price should be equal to cost of items in basket");
        }
    }
}