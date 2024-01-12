using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _prices = new Dictionary<string, int>();
        private List<string> _items = new List<string>();

        public List<string> Items { get { return _items; } }
        public Boolean Add(string product, int price)
        {
            if (!_items.Contains(product))
            {
                _items.Add(product);
                _prices.Add(product, price);
                return true;
            }
            else
            {
                {  _items.Add(product); return false;  }
            }
            
        }

        public int Total()
        {
            return _items.Select(p => _prices[p]).ToArray().Sum();
        }
    }
}
