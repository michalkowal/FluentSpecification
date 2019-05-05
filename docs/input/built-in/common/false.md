Description: Checks if candidate is False.
Order: 300
DisplayDescription: true
Support: Full;Full;Full;Full
ValidationError: <i>"Value is True"</i>.;<i>"Value is False"</i> - for negation.
---

# Usage

```csharp
var spec = Specification.False();

spec.IsSatisfiedBy(true); // false
spec.IsSatisfiedBy(false);  // true
```

## As property

```csharp
var customerSpec = Specification.False<Customer>(c => c.IsActive);

customerSpec.IsSatisfiedBy(new Customer { IsActive = true }); // false
customerSpec.IsSatisfiedBy(new Customer { IsActive = false }); // true
```