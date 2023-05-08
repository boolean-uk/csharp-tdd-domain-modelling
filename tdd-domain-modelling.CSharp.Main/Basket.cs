using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> basket = new Dictionary<string, int>()
        {
            { "milk", 1 },
            {"bread", 1 },
            {"salt", 1 },
            {"paprika", 3 },
            {"cheese", 2 }
        };

        Dictionary<string, decimal> prices = new Dictionary<string, decimal>()
        {
            {"milk", 1.50m },
            {"bread", 3.50m },
            {"salt", 0.85m },
            {"paprika", 0.99m },
            {"cheese", 7.80m }


        };

        public bool addToBasket(string product, int quantity)
        {
            if (basket.ContainsKey(product))
            {
                basket[product] += quantity;
                return false;
            }
            else
            {
                basket.Add(product, quantity);
            }
            return true;
        }

        public bool addToPrice(string product, decimal price)
        {
            if (prices.ContainsKey(product))
            {
                return false;
            }
            else
            {
                prices.Add(product, price);
            }
            return true;
        }
        public decimal total()
        {
            decimal totalprice = 0;
            foreach (string product in prices.Keys)
            {
                totalprice += basket[product] * prices[product];
            }
            return totalprice;
        }
    }
}
