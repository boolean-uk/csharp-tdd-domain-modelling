using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> basket { set; get; } = new Dictionary<string, int>() ;
        public Basket() { }

        public bool add(string name, int price)
        {
            if(basket.ContainsKey(name)) { return false; }
            basket.Add(name, price);
            return true;
        }
        public int total() {
            int total = 0;
            foreach (var item in basket)
            {
                total += item.Value;
            }
            return total;
        }

    }
}
