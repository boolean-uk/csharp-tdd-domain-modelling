using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling
{
    public class Basket
{
        public Dictionary<string, int> _items;

        public Basket()
        {
            _items = new Dictionary<string, int>();
        }

        public Boolean AddItem(string key, int value)
        {
            if (!_items.ContainsKey(key)){
                _items.Add(key, value);
                return true;
            }
            return false;
        }

        public int Total()
        {
            int total = 0;
            foreach (KeyValuePair<string, int> item in _items)
            {
                total += item.Value;
            }
            return total;
        }
}
}
