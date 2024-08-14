using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<String, int> _items = new Dictionary<String, int>();

        public bool add(string itemname, int itemprice)
        {
            if (_items.ContainsKey(itemname))
            {
                return false;
            }
            _items.Add(itemname, itemprice);

            return true;
        }

        public int total()
        {
            int price = 0;
            foreach (var item in _items)
            {
                price += item.Value;
            }

            return price;
        }
    }
    

    
}
