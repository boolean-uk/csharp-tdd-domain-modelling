using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main.Supermarket
{
    public class Order
    {
        private List<Tuple<Product, int>> _orderedItems;
        public Order()
        {
            _orderedItems = new List<Tuple<Product, int>>();
        }

        public void AddItem(Product product, int amount)
        {
            _orderedItems.Add(Tuple.Create(product, amount));
        }

        public decimal TotalCost()
        {
            throw new NotImplementedException();
        }


    }
}

