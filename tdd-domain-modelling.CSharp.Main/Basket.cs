using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> items;

        public Basket()
        {
            // Initialize the items dictionary in the constructor
            items = new Dictionary<string, int>();
        }
        public bool Add(string product, int price)
        {
            if (!items.ContainsKey(product))
            {
                items.Add(product, price);
                return true;
            }
            return false;
        }

        public int Total()
        {
            int total = 0;
            foreach (var item in items.Values)
            {
                total += item;
            }
            return total;
        }
    }
}
