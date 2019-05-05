Description: Checks if candidate is empty.
Order: 500
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Object is not empty"</i>.;<i>"Object is empty"</i> - for negation.
---

Empty means:
- Null reference.
- Empty string.
- Collection without elements.
- Object is equal to default value of T (`default(T)`).

# Usage

```csharp
var stringSpec = Specification.Empty<string>();
var arraySpec = Specification.Empty<int[]>();
var intSpec = Specification.Empty<int>();

stringSpec.IsSatisfiedBy(null); // true
stringSpec.IsSatisfiedBy("");   // true
stringSpec.IsSatisfiedBy("value");  // false

arraySpec.IsSatisfiedBy(null); // true
arraySpec.IsSatisfiedBy(new int[0]);    // true
arraySpec.IsSatisfiedBy(new int[] {10});    // false

intSpec.IsSatisfiedBy(0); // true
intSpec.IsSatisfiedBy(25); // false
```

## As property

```csharp
var customerSpec = Specification.Empty<Customer, ICollection<Item>>(c => c.Items);

customerSpec.IsSatisfiedBy(new Customer { Items = null }); // true
customerSpec.IsSatisfiedBy(new Customer { Items = new List<Item>() }); // true
customerSpec.IsSatisfiedBy(new Customer
{
    Items = new List<Item>
    {
        new Item()
    }
}); // false
```

# Not Empty

```csharp
var stringSpec = Specification.NotEmpty<string>();
var arraySpec = Specification.NotEmpty<int[]>();
var intSpec = Specification.NotEmpty<int>();

stringSpec.IsSatisfiedBy(null); // false
stringSpec.IsSatisfiedBy("");   // false
stringSpec.IsSatisfiedBy("value");  // true

arraySpec.IsSatisfiedBy(null); // false
arraySpec.IsSatisfiedBy(new int[0]);    // false
arraySpec.IsSatisfiedBy(new int[] { 10 });    // true

intSpec.IsSatisfiedBy(0); // false
intSpec.IsSatisfiedBy(25); // true
```

## As property

```csharp
var customerSpec = Specification.NotEmpty<Customer, ICollection<Item>>(c => c.Items);

customerSpec.IsSatisfiedBy(new Customer { Items = null }); // false
customerSpec.IsSatisfiedBy(new Customer { Items = new List<Item>() }); // false
customerSpec.IsSatisfiedBy(new Customer
{
    Items = new List<Item>
    {
        new Item()
    }
}); // true
```

# EF 6 support

In *Linq to entities* compare collections with null generates `NotSupportedException`.  
To prevent this, use `linqToEntities` constructor flag or global `Specification.LinqToEntities` flag.

```csharp
using (var context = new EfDbContext())
{
    var emptyItemsSpec = Specification.Empty<Customer, ICollection<Item>>(c => c.Items);
    // var customers = context.Customers.Where(emptyItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var emptyItemsSpecFixed = Specification.Empty<Customer, ICollection<Item>>(c => c.Items);
    var customers = context.Customers.Where(emptyItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```