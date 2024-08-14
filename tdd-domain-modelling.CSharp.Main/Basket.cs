

namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        private Dictionary<string, int> _basket = new ();
        public Dictionary<string, int> basket { get { return _basket; } }

        public bool Add(string product, int price)
        {
            if (basket.ContainsKey(product)) return false;
            _basket.Add(product, price);
            return true;
        }

        public int Total()
        {
            int count = 0;
            foreach (var item in _basket)
            {
                count += item.Value;
            }

            return count;
        }
    }
}