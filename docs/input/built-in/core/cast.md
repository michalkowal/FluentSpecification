Description: Converts <i>Specification</i> (candidate to verification) from one type to another.
Order: 500
DisplayDescription: true
Support: Full;Full;Full;Partial
ValidationError: <i>"Cannot cast type [{typeof(T)}] to [{typeof(TCast)}]"</i> - when <code>InvalidCastException</code>.
ValidationParameters: Specification:<i>Specification</i> object passed in constructor.
---

Useful, when you have two *Specifications* with different types and you want to join them, for one type of candidate.

# Usage

```csharp
var doubleSpec = Specification.Cast<double, int>(
    Specification.GreaterThan(0));

doubleSpec.IsSatisfiedBy(1.45);

var interfaceSpec = Specification.Cast<string, IEnumerable>(
    Specification.NotNull<IEnumerable>());

interfaceSpec.IsSatisfiedBy("");
```

## As property

```csharp
var itemSpec = Specification.Cast<Item, double, int>(i => i.Price,
    Specification.GreaterThan(0));

itemSpec.IsSatisfiedBy(new Item { Price = 1.45 });

var customerSpec = Specification.Cast<Customer, string, IEnumerable>(
    c => c.Comments,
    Specification.NotNull<IEnumerable>());

customerSpec.IsSatisfiedBy(new Customer { Comments = "" });
```

# EF 6 support

In *LinqToEntities* only primitive types, enumeration types and entity types are supported.  
Casting of any other types, generate `NotSupportedException`.