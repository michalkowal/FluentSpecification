Description: Checks if candidate is compatible with a given type.
Order: 2300
DisplayDescription: true
Support: Full;Full;Full;None
ValidationError: <i>"Object is not type of [{Expected}]"</i>.;<i>"Object is type of [{Expected}]"</i> - for negation.
ValidationParameters: Expected:Type passed in constructor.
---

# Usage

```csharp
var spec = Specification.IsType<IEnumerable>(typeof(List<int>));

spec.IsSatisfiedBy(new List<int>());    // true
spec.IsSatisfiedBy("lorem ipsum");  // false
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.IsType<Customer, ICollection<Item>>(
    c => c.Items, typeof(List<Item>));

customerSpec.IsSatisfiedBy(new Customer { Items = new List<Item>() });  // true
customerSpec.IsSatisfiedBy(new Customer { Items = new LinkedList<Item>() });    // false
customerSpec.IsSatisfiedBy(new Customer { Items = null });  // false
```

# Is Not Type

```csharp
var spec = Specification.IsNotType<IEnumerable>(typeof(List<int>));

spec.IsSatisfiedBy(new List<int>());    // false
spec.IsSatisfiedBy("lorem ipsum");  // true
spec.IsSatisfiedBy(null);   // true
```

## As property

```csharp
var customerSpec = Specification.IsNotType<Customer, ICollection<Item>>(
    c => c.Items, typeof(List<Item>));

customerSpec.IsSatisfiedBy(new Customer { Items = new List<Item>() });  // false
customerSpec.IsSatisfiedBy(new Customer { Items = new LinkedList<Item>() });    // true
customerSpec.IsSatisfiedBy(new Customer { Items = null });  // true
```

# EF 6 support

Right now `IsTypeSpecification<T>` uses `is operator` for verification - it is not supported in *LinqToEntities* (*LinqToSql*).