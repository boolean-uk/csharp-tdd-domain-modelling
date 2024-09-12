using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main.Supermarket
{
    public class Shopper
    {
        private string _name;
        private Order _cart;
        private List<Order> _orders;

        public Shopper(string name)
        {
            _name = name;
            _cart = new Order();
            _orders = new List<Order>();
        }

        public void AddToCart(Product product, int amount = 1)
        {
            Cart.AddItem(product, amount);
        }
        public void ClearCart()
        {
            Cart.Items.Clear();
        }
        public void BuyItems()
        {
            Orders.Add(Cart);
            ClearCart();
        }
        public string Name { get { return _name; } }
        public Order Cart { get { return _cart; } }
        public List<Order> Orders { get {  return _orders; } }
    }
}
