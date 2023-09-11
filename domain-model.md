| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |


As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

| Classes         | Methods                                     | Scenario                             | Outputs        |
|-----------------|---------------------------------------------|--------------------------------------|----------------|
| `Busket`        | `Sum(Dictionary<string,int> busket)`        | Get total cost of items for checkout | checkout       |
|                 | `Add(Dictionary<string,int> busket)`        | Add more if you have spare money     | updated busket |


As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.

| Classes         | Methods                                     | Scenario                                | Outputs                   |
|-----------------|---------------------------------------------|-----------------------------------------|---------------------------|
| `Busket`        | `Show(Dictionary<string,int> busket)`       | Show all items					      | busket Dictionary         |
|                 | `Sum(Dictionary<string,int> busket, count)` | Get total cost of items plus quantities | Total sum and quiantities |


Ex2
```
As a supermarket shopper,
So that I can restock my cupboards,
I want to add products into my basket.

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods											 | Scenario                                | Outputs                   |
|-----------------|--------------------------------------------------|-----------------------------------------|---------------------------|
| `Busket`        | `Show(Dictionary<string,int> busket)`            | Show all items					       | busket Dictionary         |
|                 | `Sum(Dictionary<string,int> busket, count)`      | Get total cost of items plus quantities | Total sum and quiantities |
|                 | `Add(Dictionary<string,int> busket, item, price)`| Add more if you have spare money		   | updated busket		       |
