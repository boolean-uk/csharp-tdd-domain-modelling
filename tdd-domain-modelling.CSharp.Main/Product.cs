namespace tdd_domain_modelling.CSharp.Main
{
    public class Product(string name, float price)
    {
        public string Name { get; set; } = name;
        public float Price { get; set; } = price;
    }
}