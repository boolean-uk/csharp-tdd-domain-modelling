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
            {"apple", 1 },
            {"banana", 1 },
            {"citrus", 1 },
            {"pear", 1 }
        };

        Dictionary<string, decimal> pricelist = new Dictionary<string, decimal>()
        {
            {"apple", 2.50m },
            {"banana", 1.50m },
            {"citrus", 3.50m },
            {"pear", 1.50m }
        };

        public bool addToBasket(string product, int amount)
        {
            if (basket.ContainsKey(product))
            {
                basket[product] += amount;
                return false;
            } else
            {
                basket.Add(product, amount);
            }
            return true;
        }

        public bool addToPricelist(string product, decimal price)
        {
            if (pricelist.ContainsKey(product))
            {
                return false;
            }
            else
            {
                pricelist.Add(product, price);
            }
            return true;
        }

        public decimal total()
        {
            decimal totalamount = 0;
            foreach (string product in pricelist.Keys)
            {   
                totalamount += basket[product] * pricelist[product];
            }
            return totalamount;
        }
    }
}
