using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_domain_modelling.CSharp.Main
{
    public class Shopper(float money)
    {
        private List<Product> _cupboard = new();
        private List<Product> _basket = new();
        private float _money = money;

        public float Money
        {
            get => _money;
        }

        public void Restock()
        {
            _cupboard.AddRange(_basket);
            _basket.Clear();
        }

        public void Add(Product product)
        {
            _basket.Add(product);
        }

        public void Pay()
        {
            _money -= Total();
        }

        public float Total()
        {
            float total = 0;
            foreach (Product product in _basket)
            {
                total += product.Price;
            }
            return total;
        }

        public List<Product> Cupboard { get { return _cupboard; } }
        public List<Product> Basket { get {  return _basket; } }
    }
}
