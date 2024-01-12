#Domain Models In Here

| Classes       | Members                                                                                         | Methods                                         | Scenario                            | Outputs                |
|---------------|-------------------------------------------------------------------------------------------------|-------------------------------------------------|-------------------------------------|------------------------|
| `CashReister` | `Dictonary<string, double, int> Cart` (key is product name, first item is price, second amount) | `TotalCost()`									|                                     | double                 |
|               |                                                                                                 | `Recit()`	                                    | If cart empty                       | No recit               |
|               |                                                                                                 |                                                 | If cart contains x items of x amount| Output written to file |