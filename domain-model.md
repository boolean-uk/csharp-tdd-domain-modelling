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

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `BasketCosts`	  | `totalCosts(products inside basket)`		| add item to basket     | add	   |
|			      |                                             | remove item from basket| minus   |


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods                                              | Scenario                  | Outputs							|
|-----------------|------------------------------------------------------|---------------------------|----------------------------------|
|`ShoppingHabbits`|`(List<Tuple<String, int, decimal> products, quanity, price)`  | product already in Basket |increase quantity					|
|                 |  `totalCosts method in BasketCotsts`				 | add product to basket	 |add product, quanity and price    |
|				  | `display products, quanity and price and totalcost`	 | remove product from basket|change quanity if 0 remove product|
or dict with string and array of double?
or two dicts one with product quantity other product price
