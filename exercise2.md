# 2. Use the Red Green Refactor workflow to implement a solution

There is a class in the Main project called CohortManager.cs and a test class in Test project called CohortManagerTests.cs   
Your morning teacher will demonstrate the process of creating tests from the domain model below, and then using those tests to develop robust source code.

This is known as the **Red, Green, Refactor** workflow; an important discipline to practice. Simple to learn yet difficult to master.

When writing software using this Test Driven Development approach, we don't write a complete test or complete method at a time. We write *just enough* of a test for it to fail, then write *just enough* source code to make the test pass, then refactor until the test fails and repeat this cycle.

What we are creating here are known as *unit tests*, tests that verify a single unit of our application is working correctly. They should be as small as possible, usually broken down into three parts:

1. Setup
2. Execute
3. Verify

Here's some pseudo-code to show the structure of a unit test:
```
shouldSayHello() {
    // 1. Set up
    speaker = new Speaker();
    name = "Nathan";
    
    // 2. Execute
    message = speaker.sayHello(name)
    
    // 3. Verify
    assertEquals("Hello, Nathan!", message)
}
```

### Domain model for demonstration

```
As a user,
So I can find a specific cohort,
I want to search a list of all cohorts by a cohort name.
```

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `CohortManager` | `search(List<String> cohorts, String name)` | If name is in list     | true    |
|                 |                                             | If name is not in list | false   |

### Exercise

**NOTE: Create new classes in the Main project **

**NOTE: Create any new test classes in the Test project **

- Use the Red, Green, Refactor approach to create a solution for the following domain model
- It's normal for this practice to feel difficult or frustrating in the beginning

```
As a supermarket shopper,
So that I can restock my cupboards,
I want to add products into my basket.

As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

| Classes  | Members                                                            | Methods                          | Scenario                                                   | Outputs |
|----------|--------------------------------------------------------------------|----------------------------------|------------------------------------------------------------|---------|
| `Basket` | `HashMap<String, int> items` (key is product name, value is price) | `add(String product, int price)` | Item with the provided name *is not* already in the basket | true    |
|          |                                                                    |                                  | Item with the provided name *is* already in the basket     | false   |
|          |                                                                    | `total()`                        |                                                            | int     |