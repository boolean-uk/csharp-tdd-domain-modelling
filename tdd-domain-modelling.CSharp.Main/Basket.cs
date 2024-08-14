

using System.Diagnostics.CodeAnalysis;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        Dictionary<string, int> items = new Dictionary<string, int>();

        public bool add(string item, int price)
        {
            if (items.ContainsKey(item))
            {
                return false;
            }
            else 
            { 
                items.Add(item, price);
                return true;
            }
        }

        public int total()
        {
            int totalSum = 0;

            foreach( int price in items.Values)
            {

            totalSum += price; 
            
            }

            return totalSum;
        }
   
    }
}