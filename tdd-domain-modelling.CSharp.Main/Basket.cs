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
        Dictionary<string, float> items;

        public Basket(Dictionary<string, float> items)
        {
            this.items = items;
        }
        public bool Add(string product, float price)
        {
            if (items.ContainsKey(product)) return false;
            items.Add(product, price);
            return true;
            
        }

        public float Total()
        {
            float result = 0;
            foreach (KeyValuePair<string, float> item in items)
            {
                result += item.Value;
            }
            return result;
        }
    }
}
