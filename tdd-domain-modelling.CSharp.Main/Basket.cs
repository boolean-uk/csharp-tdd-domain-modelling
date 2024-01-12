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
        public Basket() { }
        public bool Add(string name, int price) 
        {
            if(_items.ContainsKey(name))
            {
                return false;
            }
            _items.Add(name, price);

            return true; 
        }

        public int Total()
        {
            int total = 0;
            foreach(var item in _items)
            {
                total += item.Value;
            }
            return total;
        }
    }
}
