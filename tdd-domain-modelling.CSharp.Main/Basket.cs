using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();
        
        public Basket()
        {

        }

        public bool Add(string product, int price)
        {
            // Check if item is already in basket/items hashmap
            if (!_items.ContainsKey(product)) 
            {
                _items.Add(product, price);
                return true;
            }

            return false;
        }

        public int Total()
        {
            int total = 0;

            if (_items.Count == 0) 
            {
                return total;
            }

            // Calculate total sum of basket/items hashmap
            foreach (var item in _items) {
                total += item.Value;
            }

            return total;
        }

        public Dictionary<string, int> Items { get { return _items; } }
    }
}
