using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.csharp.main
{
    public class Basket
    {
        private Dictionary<string, int> _basket = new Dictionary<string, int>();

        public Dictionary<string, int> Add(string item, int price)
        {
            if (_basket.ContainsKey(item))
            {
                return _basket;
            }
            else
            {
                _basket.Add(item, price);
            }
            return _basket;
        }
        public int sum()
        {
            int totalSum = 0;
            foreach (var item in _basket)
            {
                totalSum += item.Value;
            }
            return totalSum;
        }





    }

}

