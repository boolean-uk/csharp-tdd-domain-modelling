using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling_basket.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();

        public bool add(string product, int price)
        {
            return _items.TryAdd(product, price);
        }

        public int total()
        {
            return _items.Sum(item => item.Value);
        }

    }
}
