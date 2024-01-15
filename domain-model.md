#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes        | Members                                                                | Methods | Outputs    |
|----------------|------------------------------------------------------------------------|---------|------------|
| `Basket`       | `Dictionary<String, int> basket` (key is product name, value is price) | Total() | int total  |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes              | Members                                                              | Methods | Outputs           |
|----------------------|----------------------------------------------------------------------|---------|-------------------|
| `Receipt`, `Product` | `List<Product> myBasket` Product object has name, price and quantity | Total() | myBasket and sum  |