using NUnit.Framework;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test;

[TestFixture]
public class BasketTests
{
    [TestCase("Gum", 0)]
    [TestCase("Gum", -1)]
    [TestCase("Gum", 10)]
    [TestCase("", 10)]
    public void addOnlyAddsValidProducts(string product, int price)
    {
        Basket basket = new Basket();

        bool validInput = true;
        if (product.Trim() == string.Empty) validInput = false;
        if (price < 1) validInput = false;

        Assert.AreEqual(validInput, basket.add(product, price));
    }
    [Test]
    public void addFailsIfProductAlreadyExists()
    {
        Basket basket = new Basket();
        
        string product = "product";
        basket.add(product, 1);

        Assert.AreEqual(false, basket.add(product, 1));
    }
    [Test]
    public void totalReturnsCorrectSum()
    {
        Basket basket = new Basket();

        basket.add("Cola", 22);
        basket.add("Burger", 155);
        basket.add("Fries", 32);

        Assert.AreEqual(209, basket.total());
    }
    [Test]
    public void totalReturnsZeroWhenEmpty()
    {
        Basket basket = new Basket();

        Assert.AreEqual(0, basket.total());
    }
}
