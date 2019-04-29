Description: Checks if <code>ISpecification&lt;T&gt;</code> is satisfied by ALL elements in candidate collection.
Order: 2100
DisplayDescription: true
Support: Full;Full;Full;Partial
---

*All* for **empty** collections are always valid (return *true*).  
Note that, `string` is also a collection, and can be used with this *Specification*.

# Usage

```csharp
var spec = Specification.All<int[], int>(
    Specification.GreaterThanOrEqual(100));

spec.IsSatisfiedBy(new int[] {100, 200, 300});  // true
spec.IsSatisfiedBy(new int[] {1, 200, 300});    // false
spec.IsSatisfiedBy(new int[0]);  // true!
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.All<Customer, char>(c => c.Comments,
    Specification.NotEqual('0'));

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // true!
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // false
```

# EF 6 support

In *Linq to entities* compare collections with null generates `NotSupportedException`.  
To prevent this, use `linqToEntities` constructor flag or global `Specification.LinqToEntities` flag.

```csharp
using (var context = new EfDbContext())
{
    var allItemsSpec = Specification.All<Customer, Item>(c => c.Items,
        Specification.NotEmpty<Item, int>(i => i.ItemId));
    // var customers = context.Customers.Where(allItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var allItemsSpecFixed = Specification.All<Customer, Item>(c => c.Items,
        Specification.NotEmpty<Item, int>(i => i.ItemId));
    var customers = context.Customers.Where(allItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```