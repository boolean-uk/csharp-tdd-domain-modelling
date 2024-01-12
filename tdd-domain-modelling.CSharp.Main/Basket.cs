using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Basket()
        {
        }

        public Dictionary<string, int> Items { get; set; } = new Dictionary<string, int>();

        public bool Add(string product, int price)
        {
            return Items.TryAdd(product, price);
        }

        public int Total()
        {
            if (Items.Count == 0) return -1;

            int sum = 0;
            foreach (var item in Items)
            {
                sum += item.Value;
            }

            return sum;
        }
    }
}
