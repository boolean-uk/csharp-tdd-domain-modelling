using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> items =new Dictionary<string, int>();

        public Basket() { 
        }
        //GREEN
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
            int totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Value;
            }
            return totalCost;
        }
    }
}
