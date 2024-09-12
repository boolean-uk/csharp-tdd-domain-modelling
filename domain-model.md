# Domain Model

## Entities:

### Shopper

| Field       | Type                | Description                       |
|-------------|---------------------|-----------------------------------|
| `name`      | String              | Represents the name of the user.  |
| `cart`      | Order               | Holds current items in the cart.  |
| `orders`    | List of Orders      | Holds previous orders.            |



| Method                | Return Type         | Description                                                 |
|-----------------------|---------------------|-------------------------------------------------------------|
| `BuyItems()`          | Void                | Adds items from the cart to the list of orders.              |
| `ClearCart()`         | Void                | Clears all items in the cart.                                |

### Product

| Field       | Type                | Description                       |
|-------------|---------------------|-----------------------------------|
| `name`      | String              | Represents the name of the product.|
| `price`     | Decimal             | Price of the product.              |

### Order

| Field       | Type                | Description                       |
|-------------|---------------------|-----------------------------------|
| `items`     | List of <Product, int> Tuples      | List of all products and the amount of each product. |


| Method          | Return Type         | Description                                      |
|-----------------|---------------------|--------------------------------------------------|
| `TotalCost()`   | Decimal             | Gives back the total cost of the order.          |
| `GenerateItimizedReceipt()`| Void                | Prints an itemized list of all products with the amount and price for each product and total cost. |
