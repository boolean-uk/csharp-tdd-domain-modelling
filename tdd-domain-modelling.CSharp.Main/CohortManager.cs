using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class CohortManager
    {
        private Dictionary<string, int> items;

        public CohortManager()
        {
            items = new Dictionary<string, int>();
        }

        public bool add(string product, int price)
        {
            bool notInBasket = true;

            for (int i = 0; i < items.Count(); i++)
            {
                if (items.ContainsKey(product))
                    notInBasket = false;
            }

            if (notInBasket)
                items.Add(product, price);

            return notInBasket;
        }

        public int total()
        {
            int totalCost = 0;

            for (int i = 0; i < items.Count(); i++)
                totalCost += items.ElementAt(i).Value;

            return totalCost;
        }
    }
}
