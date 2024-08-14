# Domain Models In Here

## User Story 1:
```
As a supermarket shopper,
So that I can pay for products at checkout,
I'd like to be able to know the total cost of items in my basket.
```

### Domain Model:
| Classes         | Methods                                 | Scenario                             | Outputs |
|-----------------|-----------------------------------------|--------------------------------------|---------|
| `Supermarket`   | `findTotalCost(List<Product> products)` | Sum up list cost of list of products | int     |


## User Story 2:
```
As an organised individual,
So that I can evaluate my shopping habits,
I'd like to see an itemised receipt that includes the name and price of the products
I bought as well as the quantity, and a total cost of my basket.
```

### Domain Model:
| Classes         | Methods                                 | Scenario                |    Outputs    |
|-----------------|-----------------------------------------|-------------------------|---------------|
| `Supermarket`   | `getReceipt(List<Product> products)`    | Giving list of products | Console ouput |
