using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public string Show(Dictionary<string, int> basket)
        {
            return basket.ToList().ToString();
        }

        public void Add(Dictionary<string, int> basket, string item, int price)
        {
            basket.Add(item, price);
        }

        public int Sum(Dictionary<string, int> basket)
        {
            int sum = 0;
            basket.Order();
            foreach (var item in basket)
            {
                sum = sum + item.Value;
            }
            return sum;
        }
    }
}
