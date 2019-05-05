Description: Checks if candidate is null.
Order: 400
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Object is not null"</i>.;<i>"Object is null"</i> - for negation.
---

# Usage

```csharp
var spec = Specification.Null<string>();

spec.IsSatisfiedBy(null); // true
spec.IsSatisfiedBy("");  // false
```

## As property

```csharp
var customerSpec = Specification.Null<Customer, string>(c => c.Comments);

customerSpec.IsSatisfiedBy(new Customer { Comments = null }); // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" }); // false
```

# Not Null

```csharp
var spec = Specification.NotNull<string>();

spec.IsSatisfiedBy(null); // false
spec.IsSatisfiedBy("");  // true
```

## As property

```csharp
var customerSpec = Specification.NotNull<Customer, string>(c => c.Comments);

customerSpec.IsSatisfiedBy(new Customer { Comments = null }); // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" }); // true
```

# EF 6 support

Normally `NullSpecification<T>` is fully supported in EF 6. But be aware, that different types of candidates can raise exceptions.  
Only entity types and primitive types are comparable.