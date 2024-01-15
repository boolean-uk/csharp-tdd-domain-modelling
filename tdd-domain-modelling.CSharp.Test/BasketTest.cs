using NUnit.Framework;
using tdd_domain_modelling.csharp.main;
using tdd_domain_modelling.CSharp.Main;



namespace tdd_domain_modelling.csharp.test
{
    public class BasketTests
    {
        [Test]
        public void FirstTest()
        {

            Basket basket = new Basket();
        }


        [TestCase("banana", 10)]
        [TestCase("Pineapple", 5)]
        public void Add(string item, int price)
        {
            //arrange
            Basket basket = new Basket();

            //act
            Dictionary<string, int> _basket = basket.Add(item, price);

            //assert
            Assert.IsTrue(_basket.ContainsKey(item));
        }

        [TestCase("apple", 10)]
        [TestCase("Orange", 5)]
        public void BooleanAddTest(string item, int price)
        {
            //arrange
            Basket basket = new Basket();

            //act
            Dictionary<string, int> items = basket.Add(item, price);

            //assert
            Assert.IsTrue(items.ContainsKey(item));
        }

        [Test]
        public void total()
        {
            //arrange 
            Basket basket = new Basket();
            basket.Add("apple", 10);
            basket.Add("bana", 5);
            //act 
            int result = basket.sum();

            //assert
            Assert.IsTrue(result == 15);
        }
        
    


    }
}

