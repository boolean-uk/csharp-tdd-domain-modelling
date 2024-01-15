#Domain Models In Here
# Custom Domain Model

### Scenario Excercise
# Purchasing products
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Checkout` | `public double CalculateCost(List<Products> products)`  | If there are products in list | (double) Total sum of products  |
|            |                                                  | If no products in list | 0     |
|            |                                                  | If a product has invalid cost | -1  |
|            | `bool Pay(Customer customer, double cost)`       | If customer can pay | true |
|            |                                                  | If customer can't pay | false |

# Receipt

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```
| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Receipt` | `double CalculateCost(List<Products> products)`  |  |   |
|            |                                                  | If list is empty | 0     |
