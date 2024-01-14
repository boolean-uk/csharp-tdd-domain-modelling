#Domain Models In Here


```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods										   | Scenario                     | Outputs        |
|-----------------|------------------------------------------------|------------------------------|----------------|
| `BasketManager` | 'calculate_total(List<Product> items)'		   | Calculate total cost of items| total costs    |


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods												 | Scenario                     | Outputs        |
|-----------------|------------------------------------------------------|------------------------------|----------------|
| `BasketManager` | `generate_receipt(List<Product> items)`				 | generate itemized receipt    | Recipt	       |
|			      |														 |			                    |			       |
|-----------------|------------------------------------------------------|------------------------------|----------------|
| `product`       |														 | quantity and price			|			     |
|-----------------|------------------------------------------------------|------------------------------|----------------|
| `receipt`		  | `get_itemized_details(Product product, int quantity)`| get details for each item    |item details    |
|				  |------------------------------------------------------|------------------------------|----------------|
|				  |  `get_total_cost()`									 | Calculate total cost of items| total costs    |




