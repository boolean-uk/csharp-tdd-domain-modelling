namespace tdd_domain_modelling.CSharp.Main;

public class Basket
{
    Dictionary<string, int> _items;

    public Basket()
    {
        _items = new Dictionary<string, int>();
    }

    public bool add(string product, int price)
    {
        if (product.Trim() == "") return false;
        if (price < 1) return false;
        if (_items.ContainsKey(product)) return false;
        _items.Add(product, price);
        return true;
    }

    public int total()
    {
        int sum = 0;
        foreach (var item in _items)
        {
            sum += item.Value;
        }
        return sum;
    }
}
