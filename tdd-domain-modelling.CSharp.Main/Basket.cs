using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> items = new Dictionary<string, int>();

        public bool Add(string name, int price)
        {
            if (items.ContainsKey(name))
            {
                return false;
            }
            items.Add(name, price);
            return true;
        }

        public int Total()
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
