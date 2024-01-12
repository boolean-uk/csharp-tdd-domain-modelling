###User stories:

```
1) As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```


```
2) As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```


###Domain Models:
```
1) As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods                                     | Scenario										 | Outputs |
|-----------------|---------------------------------------------|------------------------------------------------|---------|
| `Basket`		  | `sum(List<int>)`							| Calculate the sum of the value in the List     | int     |




```
2) As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes  | Members                                                            | Methods                          | Scenario                                                   | Outputs |
|----------|--------------------------------------------------------------------|----------------------------------|------------------------------------------------------------|---------|
| `Basket` | `Dictionary<String, int> items` (key is product name, value is price) | `add(String product, int price)` | Item with the provided name *is not* already in the basket | true    |
|          |                                                                    |                                  | Item with the provided name *is* already in the basket     | false   |
|          |                                                                    | `total()`                        |                                                            | int     |

| Classes         | Methods                                     | Scenario										 | Outputs				   |
|-----------------|---------------------------------------------|------------------------------------------------|-------------------------|
| `Basket`		  | `getPrice(string item)`						| return price								     | int price			   |
| 				  | `getQty(string item)`						| return quantity of the item in the basket      | int qty				   |


