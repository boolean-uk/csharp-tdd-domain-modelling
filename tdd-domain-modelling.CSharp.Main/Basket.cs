

namespace tdd_domain_modelling.CSharp.Test
{
    public class Basket
    {
        private Dictionary<string, decimal> _items = new Dictionary<string, decimal>();
        private decimal _total = 0;


        public bool Add(string item, decimal price)
        {
            if (_items.ContainsKey(item))
            {
                
                return false;
            }
            else
            {
                _items.Add(item, price);
                return true;
            }
        }

        public decimal Total()
        {
            foreach (int value in _items.Values)
            {
                _total += value;
            }

            return _total;
        }
    }
}