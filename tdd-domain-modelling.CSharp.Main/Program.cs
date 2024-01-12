// See https://aka.ms/new-console-template for more information
using tdd_domain_modelling.CSharp.Main;

Console.WriteLine("Hello, World!");

Basket basket = new Basket();

// Act:
(string, int) item = ("Cola", 10);
(string, int) item2 = ("Cola", 10);
(string, int) item3 = ("Pepsii", 5);
basket.Add(item.Item1, item.Item2);
basket.Add(item2.Item1, item2.Item2);
basket.Add(item3.Item1, item3.Item2);
var items = basket.getItems();
//Console.WriteLine(string.Join(", ", items.Select(kv => $"{kv.Key}: {kv.Value}").ToArray()));
Console.WriteLine(basket.getTotalPrice());
var tempList = basket.getReceipt();
//Console.WriteLine(string.Join(Environment.NewLine, tempList.Select(item => $"Name: {item.Item1}, Quantity: {item.Item2}, Price: {item.Item3}")));
//tempList.ForEach(item => Console.WriteLine($"Name: {item.Item1}, Quantity: {item.Item2}, Price: {item.Item3}"));