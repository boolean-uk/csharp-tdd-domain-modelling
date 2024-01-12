using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Shopper
    {
        private List<Product> _basket = new();

        public void Restock(Product product)
        {
            _basket.Add(product);
        }

        public ICollection<Product> Basket { get { return _basket; } }
    }
}
