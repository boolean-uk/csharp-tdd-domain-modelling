using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string, int> items = new Dictionary<string, int>();

        public bool add(string product, int price)
        {
            if (items.ContainsKey(product.ToLower())) 
            {
                return false;
            } else
            {
                items.Add(product.ToLower(), price);
                return true;
            }
        }
        public int total()
        {
            int result = 0;
            foreach (var item in items) { result += item.Value; }
            return result;
        }
    }
}
