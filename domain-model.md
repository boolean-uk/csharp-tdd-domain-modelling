#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods                                     | Scenario               | Outputs            |
|-----------------|---------------------------------------------|------------------------|--------------------|
| `Shopper`       | `BasketPrice(List<Product> basket)`         | If List not empty      | sum of the basket  |
|                 |                                             | If List empty          | 0                  |
|                 | `add(List<Product> basket, Product product)`|                        |                    |
| `Product`       | `get(String name, Int price)`               | If product exists      | Product            |


```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         |   Item        | Methods                                     | Scenario               | Outputs         |
|-----------------|---------------|---------------------------------------------|------------------------|-----------------|
| `Shopper`       |               | `BasketPrice(List<Product> basket)`         | If List not empty      | sum             |
|                 |               |                                             | If List empty          | 0               |
|                 |               | `add(List<Product> basket, Product product)`|                        |                 |
|                 |               | `Receit(List<Product> basket)`              | If List not empty      | List of Unique  |
|                 |               |                                             |                        | products with   |
|                 |               |                                             |                        | aggregated      |
|                 |               |                                             |                        | price & quantity|
|                 |               |                                             |                        |                 |
| `Product`       |`int price`    | `get(String name, Int price)`               | If name is not in list | Null            |
| `Product`       |`int quantity` |                                             |                        |                 |
| `Product`       |`string name`  |                                             |                        |                 |

	
- Your model doesn't have to look like the example provided in this file. If you   
  feel like you need more or less columns, feel free to go with that. 
  There is no "right way" to do this kind of thing, we're just   
  designing a system to make our lives easier when it comes to the coding part.