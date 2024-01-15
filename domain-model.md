#Domain Models In Here
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

Classes:
`Basket`

Methods:
`BasketTotal()` Summarize the total of all items in basket.
`CalculateSum()`

Scenario:
1. If basket is empty
2. If basket contains products

Output:
1. Output 0
2. Output totalprice


```	
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

Classes:
`Basket` Create a basket to hold products

Methods:
`BasketTotal()` Summarize the total of products
`PrintReceipt()` Print a receipt of items + quantity, and totalprice.

Scenario:
1. If basket is empty
2. If basket contains products

Output:
1. Output 0
2. Output totalprice