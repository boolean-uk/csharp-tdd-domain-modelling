#Domain Models In Here

## Exercise 1

User Story 1

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

User Story 2

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes      | Methods                                   | Scenario                                                        | Outputs                               |
|--------------|-------------------------------------------|-----------------------------------------------------------------|---------------------------------------|
| `Customer`   | GetTotal(Basket basket)                   | If basket is not empty                                          | Total cost of basket                  |
|              |                                           | If basket is empty                                              | 0                                     |
| `Basket`     | GetTotal(Dictionary<string, Tuple<int, int>>)  | If basket is not empty                                          | Total cost of basket                  |
|              |                                           | If basket is empty                                              | 0                                     |
| `Product`    |                                           |                                                                 |                                       |
