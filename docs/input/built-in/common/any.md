Description: Checks if <code>ISpecification&lt;T&gt;</code> is satisfied by ANY element in candidate collection.
Order: 2200
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"All elements are not specified"</i>.;Also <i>Specification</i> adds prefix with element index, for each error returned from element <i>Specification</i>.
ValidationParameters: SpecificationForAny:<i>Specification</i> object passed in constructor.
---

*Any* for **empty** collections are always invalid (return *false*).  
*Candidate* must implement `IEnumerable<>` interface.  
Note that, `string` is also a collection, and can be used with this *Specification*.

# Usage

```csharp
var spec = Specification.Any<int[], int>(
    Specification.LessThanOrEqual(0));

spec.IsSatisfiedBy(new int[] {100, 200, 0});  // true
spec.IsSatisfiedBy(new int[] {100, 200, 300});    // false
spec.IsSatisfiedBy(new int[0]);  // false
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.Any<Customer, char>(c => c.Comments,
    Specification.Equal('0'));

customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "0" });    // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "" });  // false
customerSpec.IsSatisfiedBy(new Customer { Comments = null });   // false
```

# EF 6 support

In *Linq to entities* compare collections with null generates `NotSupportedException`.  
To prevent this, use `linqToEntities` constructor flag or global `Specification.LinqToEntities` flag.

```csharp
using (var context = new EfDbContext())
{
    var anyItemsSpec = Specification.Any<Customer, Item>(c => c.Items,
        Specification.Empty<Item, int>(i => i.ItemId));
    // var customers = context.Customers.Where(anyItemsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var anyItemsSpecFixed = Specification.Any<Customer, Item>(c => c.Items,
        Specification.Empty<Item, int>(i => i.ItemId));
    var customers = context.Customers.Where(anyItemsSpecFixed.GetExpression()).ToList();   // Works!
}
```