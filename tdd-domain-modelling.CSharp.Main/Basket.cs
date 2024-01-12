using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        // public List<Product> _basket = new List<Product>();
        public Dictionary<string, int> items = new Dictionary<string, int>(); 

        public Basket() 
        { 
        }

        public bool add(string product, int price)
        {
            if (!items.Keys.Contains(product))
            {
                items[product] = price;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(string product)
        {
            if (items.Keys.Contains(product))
            {
                items.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int basketitems()
        {
            return items.Count;
        }

        public int total()
        {
            return items.Values.Sum(x => x);
        }
        
    }
}
