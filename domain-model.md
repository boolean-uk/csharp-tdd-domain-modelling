#Domain Models In Here

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes         | Methods                                                                 | Scenario                     | Outputs |
|-----------------|---------------------------------------------                            |------------------------      |---------|
| `Shopper`		  | `total() `																| If dictionary is not null		| result    |
																							| If dicrtionary is null        | returns 0   |
					`addToBusket(string name, int price)`                                   | if name doesnt exist inside 	| true + puts the name and the price inside the Dictionary |
|                 |																			 | if name exists				| false |



