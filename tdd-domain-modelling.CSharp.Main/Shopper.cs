using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Shopper
    {
        private List<Product> _cupboard = new();
        private List<Product> _basket = new();

        public void Restock()
        {
            _cupboard.AddRange(_basket);
        }

        public void Add(Product product)
        {
            _basket.Add(product);
        }

        public List<Product> Cupboard { get { return _cupboard; } }
        public List<Product> Basket { get {  return _basket; } }
    }
}
