#Domain Models In Here

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| ShopManager     | totalCostItems(List<Item> basket)           | Basketcontains items   | int     |
|                 |                                             | Basket is empty        | 0       |

As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.


| Classes         | Methods                                     | Scenario                        | Outputs          |
|-----------------|---------------------------------------------|---------------------------------|------------------|
| ShopManager     | `getUserReceipt(List<Item> basket)`         | Basket has items                | List<Item>       |  
|                 |                                             | Basket is empty                 | "Basket is empty"|



As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<string> cohorts, string name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |

As a supermarket shopper,
So that I can restock my cupboards,
I want to add products into my basket.

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.

| Classes  | Members                                                               | Methods                              | Scenario                                                   | Outputs |
|----------|-----------------------------------------------------------------------|--------------------------------------|------------------------------------------------------------|---------|
| `Basket` | `Dictionary<string, int> items` (key is product name, value is price) | `AddItem(string product, int price)` | Item with the provided name *is not* already in the basket | true    |
|          |                                                                       |                                      | Item with the provided name *is* already in the basket     | false   |
|          |                                                                       | `TotalBasketCost()`                  | Total value of items in basket                             | int     |




