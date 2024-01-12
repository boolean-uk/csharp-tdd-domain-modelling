using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
{
        public Dictionary<string, int> _shoppingBasket;
        public Basket() 
        {
            _shoppingBasket = new Dictionary<string, int>();
        }

        public bool Add(string item, int price)
        {
            if (!_shoppingBasket.ContainsKey(item))
            {
                _shoppingBasket[item] = price;
                return true;
            } else
            {
                return false;
            }
        }

        public int Total()
        {
            int total = 0;
            foreach (var item in _shoppingBasket)
            {
                total += item.Value;
            }
            return total;
        }
    }

}
