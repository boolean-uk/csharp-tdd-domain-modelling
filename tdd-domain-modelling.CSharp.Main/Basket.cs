namespace tdd_domain_modelling.CSharp.Main;
public class Basket
{
    public Dictionary<string, int> items;
    public Basket()
    {
        items = [];
    }

    public bool Add(string item, int price)
    {
        bool alreadyExists = items.ContainsKey(item);
        if (alreadyExists) return false;
        items.Add(item, price);
        return true;
    }

    public int TotalCost()
    {
        return items.Values.Sum(x => x);
    }
}