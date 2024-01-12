using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string, int> _items = new Dictionary<string, int>();
        

        public Dictionary<string, int> Add(string item, int price)
        {
            if (_items.ContainsKey(item))
            {
                return _items;
            }
            else
            {
                _items.Add(item, price);
                
            }
            return _items;
            
        }

        public bool AddBool(string item, int price)
        {
            if (_items.ContainsKey(item))
            {
                return false;
            }
            else
            {
                _items.Add(item, price);
                return true;
            }           

        }

        public int sum()
        {
            int totalSum = 0;
            foreach (var item in _items)
            {
                totalSum += item.Value;
            }
            return totalSum;
        }
    }
}
