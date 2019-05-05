Description: Checks if length of candidate is equal to specific value.
Order: 1300
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Object length is not [{Length}]"</i>.;<i>"Object length is [{Length}]"</i> - for negation.
ValidationParameters: Length:Value passed in constructor.
---

*Candidate* must implement `IEnumerable` interface.  
Note that, `string` is also a collection, and can be used with this *Specification*.

# Usage

```csharp
var spec = Specification.Length<int[]>(3);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // true
spec.IsSatisfiedBy(new int[] {100, 200});    // false
spec.IsSatisfiedBy(new int[0]);  // false
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.Length<Customer, string>(c => c.Comments, 3);

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // false
```

# Not Length

```csharp
var spec = Specification.NotLength<int[]>(3);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // false
spec.IsSatisfiedBy(new int[] {100, 200});    // true
spec.IsSatisfiedBy(new int[0]);  // true
spec.IsSatisfiedBy(null);   // true
```

## As property

```csharp
var customerSpec = Specification.NotLength<Customer, string>(c => c.Comments, 3);

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // true
```

# EF 6 support

In *Linq to entities* compare collections with null generates `NotSupportedException`.  
To prevent this, use `linqToEntities` constructor flag or global `Specification.LinqToEntities` flag.

```csharp
using (var context = new EfDbContext())
{
    var anyItemsSpec = Specification.Length<Customer, ICollection<Item>>(c => c.Items, 5);
    // var customers = context.Customers.Where(anyItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var anyItemsSpecFixed = Specification.Length<Customer, ICollection<Item>>(c => c.Items, 5);
    var customers = context.Customers.Where(anyItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```