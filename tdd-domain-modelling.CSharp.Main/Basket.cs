using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
{

    private Dictionary<string, (int Price, int Amount)> _basket = new Dictionary<string, (int, int)>();

    public Basket() {
        
    }

        public Dictionary<string, (int Price, int Amount)> basket { get { return _basket; } }

        public bool add(string item, int price)
        {
            if (_basket.Keys.Contains(item))
            {
                // keys should not be able to have different price, unique keys hsould be used
                if (_basket[item].Price != price) { throw new NotImplementedException(); }
                _basket[item] = (price, _basket[item].Amount + 1);
                return false;
            }

            _basket.Add(item, (price, 1));
            return true;
    }
        public int total()
        {
            return _basket.Values.Sum(a => a.Amount*a.Price);

        }
    }
}
