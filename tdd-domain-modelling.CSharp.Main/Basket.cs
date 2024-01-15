using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string, int> items { get; set; } = [];

        public void Add (string item, int price)
        {
            if(items.ContainsKey(item))
            {
                throw new Exception($"{item} already exists in basket");
            }

            items.Add(item, price);
        }

        public int Total()
        {
            int totalSum = 0;

            foreach (var item in items)
            {
                totalSum += item.Value;
            }

            return totalSum;
        }


    }
}
