using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace td_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();

        public Basket()
        {

        }

        public bool Add(string product, int price)
        {
            _items.Add(product, price);

            return _items.Count > 0 ? true : false;
        }

        public int Total()
        {
            return _items.Values.Sum();
        }

        public Dictionary<string, int> items { get { return _items;  } set { _items = value; } }


    } 
}


    

