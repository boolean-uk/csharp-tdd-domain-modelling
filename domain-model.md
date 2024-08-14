#Domain Models In Here

| Classes         | Methods                                     | Scenario                                             | Outputs                                                 |
|-----------------|---------------------------------------------|------------------------------------------------------|---------------------------------------------------------|
| `Basket`        | `Add(string name, int price)`               | If item doesn't exist, add to the list of items      | add item to Tuple<string name, int price, int quantity> |
|                 |                                             | If item does exist, update the quantity of item item | update the quantity of similar item in Tuple            |
|                 | `Total()`                                   | If basket is empty, return 0                         | 0                                                       |
|                 |                                             | If basket has items, calculate the cost of all items | int sum                                                 |
| `CashRegister`  | `TotalCost(Basket basket)`                  | Calculate the summed up cost of all items in basket  | int sum                                                 |


| Classes         | Methods                        | Scenario                                                                                                   | Outputs        |
|-----------------|--------------------------------|------------------------------------------------------------------------------------------------------------|----------------|
| `Basket`        | `ListItems()`                  | If basket is empty, return empty string                                                                    | string.Empty() |
| `Basket`        |                                | If basket has items, return string listing every item's name, price, and quantity in a receipt format      | string         |
| `CashRegister`  | `PrintReceipt(Basket basket)`  | Calls ListItems() and Total() from basket to create a string for the full receipt                          | string         |