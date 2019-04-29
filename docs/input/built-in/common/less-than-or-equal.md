Description: Checks if candidate object is lower than or equal to expected value.
Order: 800
DisplayDescription: true
Support: Full;Full;Full;Partial;Full
---

*Specification* for comparison use (in order):
1. `IComparer<T>` - if available.
2. *<= operator* - if defined for *T*.
3. `CompareTo()` method - if *T* implements `IComparable<T>`.
4. `CompareTo(Object)` method - if *T* implements `IComparable`.

Note that, `null` is always the lowest value.

# Usage

```csharp
var spec = Specification.LessThanOrEqual<double?>(1.45);

spec.IsSatisfiedBy(1.43);  // true
spec.IsSatisfiedBy(5.0);    // false
spec.IsSatisfiedBy(null);    // true
```

## As property

```csharp
var customerSpec = Specification.LessThanOrEqual<Customer, int>(
    c => c.CustomerId, 100);

customerSpec.IsSatisfiedBy(new Customer { CustomerId = 1 }); // true
customerSpec.IsSatisfiedBy(new Customer { CustomerId = 100 }); // true
```

# Not Less Than Or Equal

```csharp
var spec = Specification.NotLessThanOrEqual<double?>(1.45);

spec.IsSatisfiedBy(1.43);  // false
spec.IsSatisfiedBy(5.0);    // true
spec.IsSatisfiedBy(null);    // false
```

## As property

```csharp
var customerSpec = Specification.NotLessThanOrEqual<Customer, int>(
    c => c.CustomerId, 100);

customerSpec.IsSatisfiedBy(new Customer { CustomerId = 1 }); // false
customerSpec.IsSatisfiedBy(new Customer { CustomerId = 100 }); // true
```

# Comparer

`LessThanOrEqualSpecification<T>` supports `IComparer<T>`.

```csharp
var spec = Specification.LessThanOrEqual<double>(
    0.0045, Comparer<double>.Default);
```

# EF 6 support

`LessThanOrEqualSpecification<T>` works correctly in *EF 6* solution, when *T* is primitive or enum type.  
Non primitive types, may generate `NotSupportedException`.