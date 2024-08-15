#Domain Models In Here

## Analyse
The developer made an assumption that the user wants to simply know if the name is in the list or not.
They are also assuming that cohort is just stored as a string within the system, but it could also be stored as a Class.
When reading the user story, it would in my eyes be more plausible that the user wanted to find a specific cohort
in the list of all cohorts, maybe to find out more information about them just based on the name.

As it would not make sense for a search function to simply say that the cohort exists or not,
I would instead just return the cohort as a Class, like this:

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<Cohort> cohorts, String name)` | If name is in list     | cohort  |
|                 |                                             | If name is not in list | null    |

## Exercise
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

Without knowing much of how the supermarket checkout application is developed, we do not know if we should
be passing an argument or not. We are missing a lot of knowledge about how the solution is built.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Checkout`	  | `showSum(Dictionary<string, int> basket)`   | Showing sum of products| int     |

```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

Here we want to output a receipt that includes a list of the products with their name and price.
We also want to output the total number of products, as well the total cost of the products.
As a very simple case, we can just store all this information within a tuple;


| Classes         | Methods                                     | Scenario         | Outputs                |
|-----------------|---------------------------------------------|------------------|------------------------|
| `ReceiptPrinter`| `getReceipt(Dictionary<string, int> basket` | get receipt      | (dictionary, int, int) |