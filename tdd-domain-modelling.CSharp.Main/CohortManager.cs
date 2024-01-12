using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public bool search(List<string> classes, string name)
        {
            return classes.Contains(name);
        }
    }

    public class Basket
    {
        public Dictionary<string, int> items = new Dictionary<string, int>();

        public bool Add(string product, int price)
        {
            if (items.ContainsKey(product)) { 
                return false;
            }
            if(price < 0)
            {
                return false;
            }
                items.Add(product, price);
            return true;
        }

        public int total()
        {
            return items.Values.Sum();
        }
    }
}
