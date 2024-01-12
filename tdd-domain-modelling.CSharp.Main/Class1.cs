using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
 
    }

}
    public class ShoppingCart
    {
        private List<Product> items;
        public ShoppingCart ()
        {
            items = new List<Product> ();
        }

        public void Add (Product product)
        {
            items.Add (product);
        }
        public double CalculateTotal()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
            return total;
        }

    }
}
