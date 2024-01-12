using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main.Supermarket;

namespace tdd_domain_modelling.CSharp.Test.Supermarket
{
    class SupermarketTests
    {
        [Test]
        public void OrderTotalCostTest()
        {
            Order order = new Order();
            decimal totalCost = order.TotalCost();
            Assert.That(totalCost >= 0m);
        }
    }
}
