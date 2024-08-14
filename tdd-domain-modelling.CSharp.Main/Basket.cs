using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string, int> wares = new Dictionary<string, int> {
            { "apple", 5 },
            { "milk", 10 },
            { "egg", 2 },
            { "steak", 20 },
        };
        private Dictionary<string, int> basket = new Dictionary<string, int>();

        public bool add(string name)
        {
            if (wares.ContainsKey(name) && !basket.ContainsKey(name)) { 
                basket.Add(name, wares.GetValueOrDefault(name));
                return true;
            }
            return false;

        }

        public int total()
        {
            int sum = 0;
            foreach (var item in basket)
            {
                sum += item.Value;
            }
            return sum;
        }
    }
}
