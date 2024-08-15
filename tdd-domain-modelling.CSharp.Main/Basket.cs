using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> items = new Dictionary<string, int>();

        public bool add(string product, int price)
        {
            if (items.ContainsKey(product)) return false;
            items.Add(product, price);
            return true;
        }

        public int total()
        {
            int sum = 0;
            foreach (var item in items)
            {
                sum += item.Value;
            }
            return sum;
        }
    }
}
