using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket{

        Dictionary<string,int> basket = new Dictionary<string, int>();
        
        public bool add(string product,int price) {

            
            if(basket.Keys.Contains(product))
            {
                return false;
            }
            else
            {
                basket.Add(product, price);
                return true;
            }
            
}
        public int total() {

            int total = 0;
            foreach(string product in basket.Keys) { 
                total += basket[product]; }
            
            
            return total; 
        
        }

}
}
