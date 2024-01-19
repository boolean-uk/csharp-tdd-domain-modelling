namespace tdd_domain_modelling.CSharp.Main
{
    public class Basket
    {
        public List<Item> items { get; }

        public Basket()
        {
            items = new List<Item>();
        }

        public void AddItem(string itemName, float price)
        {
            items.Add(new Item(itemName, price));
        }

        public float TotalCost()
        {
            float totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            return totalCost;
        }

        public List<string> Receipt()
        {
            List<string> receipt = new List<string>();
            Dictionary<Item, float> itemQuantity = new Dictionary<Item, float>();
            foreach (var item in items)
            {
                if (!itemQuantity.ContainsKey(item))
                {
                    itemQuantity.Add(item, 1);
                }
                else
                {
                    itemQuantity[item]++;
                }
            }

            foreach (var item in itemQuantity)
            {
                receipt.Add($"|{item.Key.ItemName}|{item.Key.Cost}|x{item.Value}");
            }
            receipt.Add($"Total cost: {TotalCost()}");
            return receipt;
        }
    }

    public struct Item
    {
        public string ItemName { get; }
        public float Cost { get; }
        public Item(string itemName, float cost)
        {
            ItemName = itemName;
            Cost = cost;
        }
    }
}
