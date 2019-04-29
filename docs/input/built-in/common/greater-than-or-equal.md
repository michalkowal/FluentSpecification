Description: Checks if candidate object is greater than or equal to expected value.
Order: 1000
DisplayDescription: true
Support: Full;Full;Full;Partial;Full
---

*Specification* for comparison use (in order):
1. `IComparer<T>` - if available.
2. *>= operator* - if defined for *T*.
3. `CompareTo()` method - if *T* implements `IComparable<T>`.
4. `CompareTo(Object)` method - if *T* implements `IComparable`.

Note that, `null` is always the lowest value.

# Usage

```csharp
var spec = Specification.GreaterThanOrEqual<double?>(1.45);

spec.IsSatisfiedBy(1.43);  // false
spec.IsSatisfiedBy(5.0);    // true
spec.IsSatisfiedBy(null);    // false
```

## As property

```csharp
var customerSpec = Specification.GreaterThanOrEqual<Customer, int>(
    c => c.CustomerId, 100);

customerSpec.IsSatisfiedBy(new Customer { CustomerId = 1 }); // false
customerSpec.IsSatisfiedBy(new Customer { CustomerId = 100 }); // true
```

# Not Greater Than Or Equal

```csharp
var spec = Specification.NotGreaterThanOrEqual<double?>(1.45);

spec.IsSatisfiedBy(1.43);  // true
spec.IsSatisfiedBy(5.0);    // false
spec.IsSatisfiedBy(null);    // true
```

## As property

```csharp
var customerSpec = Specification.NotGreaterThanOrEqual<Customer, int>(
    c => c.CustomerId, 100);

customerSpec.IsSatisfiedBy(new Customer { CustomerId = 1 }); // true
customerSpec.IsSatisfiedBy(new Customer { CustomerId = 100 }); // true
```

# Comparer

`GreaterThanOrEqualSpecification<T>` supports `IComparer<T>`.

```csharp
var spec = Specification.GreaterThanOrEqual<double>(
    0.0045, Comparer<double>.Default);
```

# EF 6 support

`GreaterThanOrEqualSpecification<T>` works correctly in *EF 6* solution, when *T* is primitive or enum type.  
Non primitive types, may generate `NotSupportedException`.