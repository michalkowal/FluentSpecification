Description: Checks if length of candidate is between Min and Max values.
Order: 1600
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Object length is not between [{MinLength}] and [{MaxLength}]"</i>.;<i>"Object length is between [{MinLength}] and [{MaxLength}]"</i> - for negation.
ValidationParameters: MinLength:Min value passed in constructor.;MaxLength:Max value passed in constructor.
---

*Candidate* must implement `IEnumerable` interface.  
Note that, `string` is also a collection, and can be used with this *Specification*.

# Usage

```csharp
var spec = Specification.LengthBetween<int[]>(3, 5);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // true
spec.IsSatisfiedBy(new int[] {100, 200});    // false
spec.IsSatisfiedBy(new int[0]);  // false
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.LengthBetween<Customer, string>(c => c.Comments, 3, 5);

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // false
```

# Not Length Between

```csharp
var spec = Specification.NotLengthBetween<int[]>(3, 5);

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // false
spec.IsSatisfiedBy(new int[] {100, 200});    // true
spec.IsSatisfiedBy(new int[0]);  // true
spec.IsSatisfiedBy(null);   // true
```

## As property

```csharp
var customerSpec = Specification.NotLengthBetween<Customer, string>(c => c.Comments, 3, 5);

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
    var anyItemsSpec = Specification.LengthBetween<Customer, ICollection<Item>>(c => c.Items, 1, 5);
    // var customers = context.Customers.Where(anyItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var anyItemsSpecFixed = Specification.LengthBetween<Customer, ICollection<Item>>(c => c.Items, 1, 5);
    var customers = context.Customers.Where(anyItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```