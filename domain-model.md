#Domain Models In Here

```
As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes  | Members                               | Methods                       | Scenario                                                 | Outputs |
|----------|---------------------------------------|-------------------------------|----------------------------------------------------------|---------|
| `Basket` | Dictionary<String, int> products      | `add(String name, int price)` | Item with the provided name is not already in the basket | true    |
|          | (key is product name, value is price) |                               | Item with the provided name is already in the basket     | false   |
|          |                                       |`total()`                      |                                                          | int     |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```