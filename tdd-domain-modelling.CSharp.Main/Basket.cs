using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
        public class Basket
    {
        public Dictionary<string, double> items = new Dictionary<string, double>(); 

        public Basket()
        {

        }

        public bool addItemsToBasket(string itemName, double price)
        {
            // if itemName is not in items Dicionary, add itemName and Price to items Dicionary
            if (!items.ContainsKey(itemName))
            {
                items.Add(itemName, price);
                return true;
            }
            return false;
        }

        
        public double TotalCostsBasket()
        {
            double totalCosts = 0;
            foreach (var item in items)
            {
                totalCosts += item.Value;
            }
            return totalCosts;
        }
    }
}
