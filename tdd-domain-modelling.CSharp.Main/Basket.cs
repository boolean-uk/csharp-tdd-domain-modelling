using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string,double> _items;
            
        public Basket()
        {
            _items = new Dictionary<string,double>();
        }

        public void Add(string product, double price)
        {
            if (_items.ContainsKey(product))
            {
                _items[product] += price;
            }
            else
            {
                _items.Add(product, price);
            }
        }

        public bool Contains(string product)
        {
            return _items.ContainsKey(product);
        }

        public double Sum()
        {
            return _items.Values.Sum();
        }
    }
}
