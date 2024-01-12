#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
| Classes         | Methods                                        | Scenario               | Outputs |
|-----------------|------------------------------------------------|------------------------|---------|
| `CohortManager` | `BasketSum(Dictionary<string, int> basket)`    | If basket not empty    | decimal |
|                 |                                                | If basket empty        | -1D     |


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods                                                 | Scenario               | Outputs                                          |
|-----------------|---------------------------------------------------------|------------------------|--------------------------------------------------|
| `CohortManager` | `ItemisedReciept(Dictionaly<string, decimal> Purchase)` | If basket not empty    | List<Dictionary<string, decimal, int>> ShopFinal |
|                 |                                                         | If basket empty        | null                                             |

