using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {

        private readonly Dictionary<string, int> _items = new Dictionary<string, int>();

        public bool add(string product, int price)
        {
            if (_items.ContainsKey(product))
            {
                return false;
            }

            _items.Add(product, price);
            return true;
           
        }

        public int total()
        {
            return _items.Values.Sum();
        }
    }
}
