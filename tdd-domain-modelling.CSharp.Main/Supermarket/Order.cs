using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main.Supermarket
{
    public class Order
    {
        private List<Tuple<Product, int>> _items;
        public Order()
        {
            _items = new List<Tuple<Product, int>>();
        }

        public void AddItem(Product product, int amount)
        {
            _items.Add(Tuple.Create(product, amount));
        }

        public decimal TotalCost()
        {
            throw new NotImplementedException();
        }
        public string GenerateItimizedReceipt()
        {
            throw new NotImplementedException();
        }

        public List<Tuple<Product, int>> Items { get { return _items; } }


    }
}

