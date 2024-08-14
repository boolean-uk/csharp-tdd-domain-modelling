#Domain Models In Here

First Domain Model
| Classes         | Methods                                      | Scenario             | Outputs           |
|-----------------|----------------------------------------------|----------------------|-------------------|
| `Cashier`		  | `scanItems(Dictionary<string, int> basket)`  | if List is populated | Sum of item.Value |

Second Domain Model
| Classes         | Methods                                         | Scenario               | Outputs                                     |
|-----------------|-------------------------------------------------|------------------------|---------------------------------------------|
| `Cashier`		  | `printReciept(Dictionary<string, int> basket)`  | if List is populated   | Returns tupleList with name, cost, quantity |
| `Cashier`		  | `totalCost(IList<Tuple<T1, T2, T3>> list)`      | if List is populated   | Sum of item.Value                           |
