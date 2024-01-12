using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        public CohortManager()
        {
            AvailableItems = new Dictionary<string, decimal>()
            {
                { "soda", 3 },
                { "apple", 2 },
                { "rice", 1 },
                { "milk", 10 },
                { "chocolate", 5 }
            };
        }

        public Dictionary<string, decimal> AvailableItems { get; set; }

        //Dict, Name of item, amount of item
        public Dictionary<string, int> Basket { get; set; } = new Dictionary<string, int>();

        public decimal BasketSum(Dictionary<string, int> basket)
        {
            if (basket.Count == 0) return -1;

            decimal sum = 0;
            foreach (var item in basket)
            {
                sum += AvailableItems.ContainsKey(item.Key) ? AvailableItems.GetValueOrDefault(item.Key) * item.Value : 0;
            }

            return sum;
        }

        public bool Search(List<String> cohorts, String name)
        {
            return cohorts.Contains(name);
        }


    }
}
