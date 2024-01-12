namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public Dictionary<string , int> items = new Dictionary<string , int>();

        public bool Add(string product , int price)
        {
            if(items.ContainsKey(product))
            {
                return false;
            }
            else
            {
                items.Add(product , price);
                return true;
            }
        }

        public int Total()
        {
            int total = 0;
            foreach(int price in items.Values)
            {
                total += price;
            }
            return total;
        }
    }
}
