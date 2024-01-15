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

        [Test]
        public void OrderItemsTest()
        {
            Order order = new Order();
            List<Tuple<Product, int>> items = order.Items;
            Assert.That(items.Count == 0);
        }

        [Test]
        public void ProductTest()
        {
            Product product1 = new Product("Milk", 12.5m);
            Product product2 = new Product("Flour", 15m);
            Product product3 = new Product("Eggs", 15m);
            Assert.That(product1.Price < product2.Price);
            Assert.That(product2.Price == product3.Price);
        }

        [Test]
        public void ShopperAddToCartTest()
        {
            Shopper shopper1 = new Shopper("Phillip");
            Shopper shopper2 = new Shopper("Cathrine");
            Product cheese = new Product("Cheese", 20m);
            Product wine = new Product("Wine", 45m);
            Product fish = new Product("Fish", 25m);
            Assert.That(shopper1.Cart.Items.Count == 0);
            Assert.That(shopper2.Cart.Items.Count == 0);
            shopper1.AddToCart(wine);
            shopper2.AddToCart(cheese);
            shopper2.AddToCart(fish);
            Assert.That(shopper1.Cart.Items.Count == 1);
            Assert.That(shopper2.Cart.Items.Count == 2);
            Assert.That(shopper1.Cart.TotalCost() == shopper2.Cart.TotalCost());
        }

        [Test]
        public void ShopperClearCartTest()
        {
            Shopper shopper = new Shopper("Phillip");
            Product wine = new Product("Wine", 45m);
            Product orange = new Product("Orange", 4m);
            Assert.That(shopper.Cart.Items.Count == 0);
            shopper.AddToCart(wine, 200);
            shopper.AddToCart(orange);
            Assert.That(shopper.Cart.Items.Count == 2);
            shopper.ClearCart();
            Assert.That(shopper.Cart.Items.Count == 0);
            shopper.AddToCart(orange);
            Assert.That(shopper.Cart.Items.Count == 1);
        }

        [Test]
        public void ShopperBuyItemsTest()
        {
            Shopper shopper = new Shopper("Phillip");
            Product wine = new Product("Wine", 45m);
            for (int i = 0;  i < 7; i++)
            {
                shopper.AddToCart(wine, 90);
                Assert.That(shopper.Cart.Items.Count() == 1);
                Assert.That(shopper.Orders.Count() == i);
                shopper.BuyItems();
                Assert.That(shopper.Cart.Items.Count() == 0);
                Assert.That(shopper.Orders.Count() == i + 1);
            }
        }
    }
}
