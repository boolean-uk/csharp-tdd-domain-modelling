#Domain Models In Here



> As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```
>
> | Classes         | Methods                                     | Scenario             | Outputs      |
|-----------------|---------------------------------------------|------------------------|--------------|
| `CohortManager` | `search(List<String> cohorts, String name)` | if index != null       | int index/id |
|                 |                                             | If name is not in list | false        |

Comment: when looking for a element its useful to know where it was located if you want to access it further/later.
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
> | Classes         | Methods                                   | Scenario               | Outputs                |
|-----------------|---------------------------------------------|------------------------|------------------------|
| `checkOut`      | `search(List<int> ItemsInStore, int ItemId)`| if ItemId in list      | keyValuePair<name,cost>|
|                 | `AddToTotal(int cost)`                      | int + total            | int totalcost          |
search() - checking for item with a unique id to prevent finding several items with similar names but different cost
ItemId - scanning or typing a unique code from the product finding the same code in DB

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Methods                                   | Scenario               | Outputs                              |
|-----------------|-------------------------------------------|------------------------|------------------------              |
| `checkOut`      | `search(List<int> ItemsInStore, int name)`| if name in list        | Tuple<name,cost>                     |
|                 | `AddToTotal(T(name,cost,numOfItems))`     | Add Tuple to List      | List<Tuple<name,cost,num>>, TotalCost|