using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_domain_modelling.CSharp.Main
{
          public class Shopper
          {
        public  Dictionary<string, int> _busket ;
        public Shopper() {
            _busket = new Dictionary<string, int>();
            _busket.Add( "apple", 5);
            _busket.Add( "banana", 10);
            _busket.Add("carrot", 3);




        }

        public bool addProduct(string name, int price)
        {
            if (!_busket.ContainsKey(name))
            {
                _busket[name] = price;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int total() {

            int total = 0;
            foreach (KeyValuePair<string,int> kvp in _busket)
            {
                total += kvp.Value;
            }
            return total;
        }

    
    }

        
}
