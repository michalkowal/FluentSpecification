Description: Checks if external <i>Linq</i> <i>Expression</i> is satisfied by candidate.
Order: 100
DisplayDescription: true
Support: Partial;Full;Partial;Partial
---

# Usage

```csharp
var spec = Specification.Expression<string>(
    s => s.Split(new char[] {';'}).Length == 3);

spec.IsSatisfiedBy("1;2;3"); // true
spec.IsSatisfiedBy("");  // false
spec.IsSatisfiedBy(null);  // NullReferenceException!
```

## As property

```csharp
var customerSpec = Specification.Expression<Customer, string>(c => c.Comments,
    s => s.Split(new char[] { ';' }).Length == 3);

customerSpec.IsSatisfiedBy(new Customer { Comments = "1;2;3" }); // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "" }); // false
customerSpec.IsSatisfiedBy(new Customer { Comments = null }); // NullReferenceException
```

# Null support

`ExpressionSpecification<T>` doesn't check if candidate is null.  
If provided *Linq expression* is not prepared for *null* candidate value - `NullReferenceException` may occured.

# EF support

*Entity Framework* support (both - Core and "normall") depends on provided *Linq expression* construction.  
`ExpressionSpecification<T>` doesn't modify expression in any way.