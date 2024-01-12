using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string, int> items = new Dictionary<string, int>();
        public int totalCost { get { return total(); } }

        public Basket()
        {
            items = new Dictionary<string, int>();
        }

        public bool Add(string productName, int price)
        {

            
               return items.TryAdd(productName, price);
            
        }

        public int total()
        {   
            if (items.Count == 0) return 0;

            return items.Values.Aggregate(0, (tot,next)=> tot +=next);
        }
    }
}



