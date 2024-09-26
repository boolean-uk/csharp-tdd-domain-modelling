# Domain Models

| Classes         | Methods                                          | Scenario               | Outputs |
|-----------------|--------------------------------------------------|------------------------|---------|
| `Basket`        | `totalCost(Dictionary<string, int> items)` (key is product name, value is quantity) | User Story #1     | total cost of items in basket |
| `Basket`        | `toReceipt()`                                    | User Story #2 | `List<string>` (each element is a row of the receipt `"name quantity price"` and the last element is `"Total: cost"`) |
