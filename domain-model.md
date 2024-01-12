#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         |   Item           |  Methods                               | Scenario               | Outputs                        |
|-----------------|-----------------------------------------------------------|------------------------|--------------------------------|
| `Shopper`       | `List<Product>`  |`BasketPrice(List<Product> basket)`     | `If List not empty`    |`sum of the basket list prices` |
|                 |                  |                                        | `If List empty`        | 0                              |
|                 |                  | `AddProduct(Product product)`          |                        |                                |
| `Product`       | `string name`    |                                        |                        |                                |
|                 | `int price`      |                                        |                        |                                |


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
|                 |               | `AddProduct(Product product)`               |                        |                 |
|                 |               | `Receit(List<Product> basket)`              | If List not empty      | List of         |
|                 |               |                                             |                        | products with   |
|                 |               |                                             |                        | price & quantity|
|                 |               |                                             |                        | and total sum   |
|                 |               |                                             | If List empty          | empty list      |
| `Product`       |`int price`    |                                             |                        |                 |
|                 |`int quantity` |                                             |                        |                 |
|                 |`string name`  |                                             |                        |                 |

	
- Your model doesn't have to look like the example provided in this file. If you   
  feel like you need more or less columns, feel free to go with that. 
  There is no "right way" to do this kind of thing, we're just   
  designing a system to make our lives easier when it comes to the coding part.