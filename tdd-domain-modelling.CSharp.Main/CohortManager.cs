using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public CohortManager() { }
    }
    public class Basket
    {
        public Dictionary<string, int> Items { get; set; }

        public Basket() 
        {
            Items = new Dictionary<string, int>();
        }
        public bool Add(string product, int price)
        {
            bool itemExists = Items.ContainsKey(product);

            if (!itemExists)
            {
                Items.Add(product, price);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Total()
        {
            int result = 0;
            foreach (KeyValuePair<string, int> item in Items)
            {
                result += item.Value;
            }
            return result;
        }
    }
}
