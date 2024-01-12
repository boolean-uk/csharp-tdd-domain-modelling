using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
{
    private Dictionary<string, int> items = new Dictionary<string, int>();

    public bool add(string product, int price)
    {
        if (items.ContainsKey(product))
        {
            return false; // Product already in the basket
        }

        items.Add(product, price);
        return true;
    }

    public int Total()
    {
        return items.Values.Sum(); // Summing up the prices of all items in the basket
    }
}
}
