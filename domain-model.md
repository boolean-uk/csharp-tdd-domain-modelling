#Domain Models In Here


### Exercise 1
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

//when I did the first user story, it quickly expanded in a way that it quickly encompassed the second user story as well before I even read that one. Therefore they are combined. 
//Product would be static I think and have Name and Price as fields.
| Classes         | Methods                                        | Scenario                          | Outputs |
|-----------------|------------------------------------------------|-----------------------------------|---------|
| `Customer`	  | `seeTotalAmount()`							   | If Basket is populated            | double  |
|                 |                                                | If it is empty		               | 0       |
|                 | `addProductToBasket(Product prod, int qty)`    | If Product is added	           | true    |
|                 |                                                | If Product is not added		   | false   |
|                 |                                                | If right qty added		           | true    |
|                 |                                                | If wrong qty added	               | false   |
|                 |                                                | If Product doesn't exists in Bskt | true    |
|                 |                                                | If Product already exists         | false   |
|                 | `removeProductToBasket(Product prod, int qty)` | If Product is removed             | true    |
|                 |                                                | If Product is not removed		   | false   |
|                 |                                                | If right qty removed	           | true    |
|                 |                                                | If wrong qty removed	           | false   |
|                 | `checkOut()`                                   | If numbers add up correctly       | true    |
|                 |                                                | If numbers are wrong              | false   |
| `Basket`        | `addProductToBasket(Product prod, int qty)`    | If Product is added	           | true    |
|                 |                                                | If Product is not added		   | false   |
|                 |                                                | If right qty added		           | true    |
|                 |                                                | If wrong qty added	               | false   |
|                 | `removeProductToBasket(Product prod, int qty)` | If Product is removed             | true    |
|                 |                                                | If Product is not removed		   | false   |
|                 |                                                | If right qty removed	           | true    |
|                 |                                                | If wrong qty removed	           | false   |
|                 | `calculateTotalAmount()`                       | If Basket is populated	   		   | double  |
|                 |                                                | If it is empty		               | 0       |
|                 | `completeBasket()`                             | If Basket is cleared       	   | true    |
|                 |                                                | If Basket is not cleared	       | false   |
| `Product`       |												   |				          		   |         |