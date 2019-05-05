Description: Checks if length of candidate is greater than or equal to Min value.
Order: 1400
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Object length is lower than [{MinLength}]"</i>.;<i>"Object length is greater than [{MinLength}]"</i> - for negation.
ValidationParameters: MinLength:Value passed in constructor.
---

*Candidate* must implement `IEnumerable` interface.  
Note that, `string` is also a collection, and can be used with this *Specification*.

# Usage

```csharp
var spec = Specification.MinLength<int[]>(3);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // true
spec.IsSatisfiedBy(new int[] {100, 200});    // false
spec.IsSatisfiedBy(new int[0]);  // false
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.MinLength<Customer, string>(c => c.Comments, 3);

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // false
```

# Not Min Length

```csharp
var spec = Specification.NotMinLength<int[]>(3);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // false
spec.IsSatisfiedBy(new int[] {100, 200});    // true
spec.IsSatisfiedBy(new int[0]);  // true
spec.IsSatisfiedBy(null);   // true
```

## As property

```csharp
var customerSpec = Specification.NotMinLength<Customer, string>(c => c.Comments, 3);

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
    var anyItemsSpec = Specification.MinLength<Customer, ICollection<Item>>(c => c.Items, 1);
    // var customers = context.Customers.Where(anyItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var anyItemsSpecFixed = Specification.MinLength<Customer, ICollection<Item>>(c => c.Items, 1);
    var customers = context.Customers.Where(anyItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```