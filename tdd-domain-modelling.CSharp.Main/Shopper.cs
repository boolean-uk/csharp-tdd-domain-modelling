using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Shopper
    {
        public List<Product> _basket = new List<Product>();

        public Shopper()
        {
        }

        public void AddProduct(Product product)
        {
            List<string> names = new List<string>();

            foreach (var item in _basket)
            {
                names.Add(item._name);
            }

            if (!names.Contains(product._name))
            {
                this._basket.Add(product);
            }
            // return this._basket;

        }

        public int BasketPrice()
        {
            int total = 0;

            foreach (var item in _basket)
            {
                total = total + item._price;
            }
            return total;
        }

        public List<Product> Receit()
        {

            return _basket;
        }
    }
}
