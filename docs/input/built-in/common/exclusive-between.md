Description: Checks if candidate object is between (exclusive) min and max value.
Order: 1200
DisplayDescription: true
Support: Full;Full;Full;Partial;Full
ValidationError: <i>"Value is not between [{From}] and [{To}]"</i>.;<i>"Value is between [{From}] and [{To}]"</i> - for negation.
ValidationParameters: From:"From" value passed in constructor.;To:"To" value passed in constructor.
---

*Specification* for comparison use (in order):
1. `IComparer<T>` - if available.
2. *< and > operator* - if defined for *T*.
3. `CompareTo()` method - if *T* implements `IComparable<T>`.
4. `CompareTo(Object)` method - if *T* implements `IComparable`.

Note that, `null` is always the lowest value.

# Usage

```csharp
var spec = Specification.ExclusiveBetween<double?>(1.0, 1.45);

spec.IsSatisfiedBy(1.43);  // true
spec.IsSatisfiedBy(5.0);    // false
spec.IsSatisfiedBy(null);    // false
```

## As property

```csharp
var customerSpec = Specification.ExclusiveBetween<Customer, int>(
    c => c.CustomerId, 0, 100);

customerSpec.IsSatisfiedBy(new Customer { CustomerId = 1 }); // true
customerSpec.IsSatisfiedBy(new Customer { CustomerId = 100 }); // false
```

# Not Exclusive Between

```csharp
var spec = Specification.NotExclusiveBetween<double?>(1.0, 1.45);

spec.IsSatisfiedBy(1.43);  // false
spec.IsSatisfiedBy(5.0);    // true
spec.IsSatisfiedBy(null);    // true
```

## As property

```csharp
var customerSpec = Specification.NotExclusiveBetween<Customer, int>(
    c => c.CustomerId, 0, 100);

customerSpec.IsSatisfiedBy(new Customer { CustomerId = 1 }); // false
customerSpec.IsSatisfiedBy(new Customer { CustomerId = 100 }); // true
```

# Comparer

`ExclusiveBetweenSpecification<T>` supports `IComparer<T>`.

```csharp
var spec = Specification.ExclusiveBetweenSpecification<double>(
    1.0, 1.5, Comparer<double>.Default);
```

# EF 6 support

`ExclusiveBetweenSpecification<T>` works correctly in *EF 6* solution, when *T* is primitive or enum type.  
Non primitive types, may generate `NotSupportedException`.