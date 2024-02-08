using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket 
    {
        int totalCost;
        public Dictionary<string, int> items = new Dictionary<string, int>();
        public bool addItem(string name, int price)
        {
            if (items.ContainsKey(name))
            {
                return false;
            }
            items[name] = price;
            totalCost += price;
            return true;
        }
        public int total()
        {
            return totalCost;
        }
    }
}
