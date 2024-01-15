# 1. Extract domain models from user stories

### Warm up

A **User Story** describes one thing a program is expected to do, from the perspective of somebody using that program. When planning a program, the client's requirements will be decomposed into many User Stories. Much of a developer's life is spent translating User Stories into a functional system. These systems are made up of different components, and each component is made up of units. We call these systems **Domain Models**.

There are various different formats for user stories but they all share a common goal: describe a feature the user wants. Here's one style of user story:

```
As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```

As a developer, it's our job to extract the useful information into a functional system. Look for nouns and verbs; nouns usually describe entities, verbs usually describe methods.

Here is how one might design a domain model for the above user story:

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |

> **Time to analyse**
>
> Evaluate the user story and the domain model above. What assumptions did the developer have to make and what would you do differently?
> The List in Methods could have been concisting of Objects instead of string. The output is of boolean value.
> The user could have wanted the whoule course if it was a object with other attributes.
> Name of class could be different. You would not necessary have to pass the list of cohorts as well as the string.
> 
> Create your own domain model for the user story above, try to come up with a different solution than the model provided. You can use a table like the one above, a spreadsheet, pen and paper, whatever you'd like. Share your work in your cohorts classroom channel when you're done.
>
> 
| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `find(List<Cohort> cohorts, String name)   `| If name is in list     |Cohort c |	
|                 |                                             | If name is not in list |Exception|  
### Exercise

Follow the same process as above to translate these two user stories into domain models.

```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```
| Classes         | Methods                                     | Scenario               | Outputs   |
|-----------------|---------------------------------------------|------------------------|---------  |
| `Supermarket	` | `double Sum(List<double> products)`         | Sum prices together    | double sum|
                                       
```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

| Classes         | Members              |Methods                  | Scenario               | Outputs    |
|-----------------|----------------------|-------------------------|------------------------|------------|
|`Product`	  | `string code, double price`, int quantity|			   |                        |            |

|`Reciept`	  |`List<Product> prods` |`double SumOfProducts() `|Add prods.price * prods.quantity  | 		return sum




- Add your domain models as images to the project, or in the `domain-model.md` file.   
	
- Your model doesn't have to look like the example provided in this file. If you   
  feel like you need more or less columns, feel free to go with that. 
  There is no "right way" to do this kind of thing, we're just   
  designing a system to make our lives easier when it comes to the coding part.
