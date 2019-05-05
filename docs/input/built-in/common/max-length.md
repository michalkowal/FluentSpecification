Description: Checks if length of candidate is lower than or equal to Max value.
Order: 1500
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Object length is greater than [{MaxLength}]"</i>.;<i>"Object length is lower than [{MaxLength}]"</i> - for negation.
ValidationParameters: MaxLength:Value passed in constructor.
---

*Candidate* must implement `IEnumerable` interface.  
Note that, `string` is also a collection, and can be used with this *Specification*.

# Usage

```csharp
var spec = Specification.MaxLength<int[]>(3);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // true
spec.IsSatisfiedBy(new int[] {100, 200});    // true
spec.IsSatisfiedBy(new int[0]);  // true
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.MaxLength<Customer, string>(c => c.Comments, 3);

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // false
```

# Not Max Length

```csharp
var spec = Specification.NotMaxLength<int[]>(3);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // false
spec.IsSatisfiedBy(new int[] {100, 200});    // false
spec.IsSatisfiedBy(new int[0]);  // false
spec.IsSatisfiedBy(null);   // true
```

## As property

```csharp
var customerSpec = Specification.NotMaxLength<Customer, string>(c => c.Comments, 3);

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // true
```

# EF 6 support

In *Linq to entities* compare collections with null generates `NotSupportedException`.  
To prevent this, use `linqToEntities` constructor flag or global `Specification.LinqToEntities` flag.

```csharp
using (var context = new EfDbContext())
{
    var anyItemsSpec = Specification.MaxLength<Customer, ICollection<Item>>(c => c.Items, 5);
    // var customers = context.Customers.Where(anyItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var anyItemsSpecFixed = Specification.MaxLength<Customer, ICollection<Item>>(c => c.Items, 5);
    var customers = context.Customers.Where(anyItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```