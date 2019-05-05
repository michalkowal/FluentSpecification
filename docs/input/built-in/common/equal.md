Description: Checks if candidate object is equal to expected object.
Order: 600
DisplayDescription: true
Support: Full;Full;Full;Partial;Full
ValidationError: <i>"Object is not equal to [{Expected}]"</i>.;<i>"Object is equal to [{Expected}]"</i> - for negation.
ValidationParameters: Expected:Expected object passed in constructor.
---

*Specification* for comparison use (in order):
1. `IEqualityComparer<T>` - if available.
2. *== operator* - if defined for *T*.
3. `CompareTo()` method - if *T* implements `IComparable<T>`.
4. `CompareTo(Object)` method - if *T* implements `IComparable`.
5. `Equals()` method - if *T* implements `IEquatable<T>`.
6. `Equals(Object)`.

# Usage

```csharp
var spec = Specification.Equal("lorem ipsum");

spec.IsSatisfiedBy("lorem ipsum");  // true
spec.IsSatisfiedBy("ipsum");    // false
spec.IsSatisfiedBy(null);   // false
```

## As property

```csharp
var customerSpec = Specification.Equal<Customer, string>(
    c => c.Comments, null);

customerSpec.IsSatisfiedBy(new Customer {Comments = null}); // true
customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" }); // false
```

# Not Equal

```csharp
var spec = Specification.NotEqual("lorem ipsum");

spec.IsSatisfiedBy("lorem ipsum");  // false
spec.IsSatisfiedBy("ipsum");    // true
spec.IsSatisfiedBy(null);   // true
```

## As property

```csharp
var customerSpec = Specification.NotEqual<Customer, string>(
    c => c.Comments, null);

customerSpec.IsSatisfiedBy(new Customer {Comments = null}); // false
customerSpec.IsSatisfiedBy(new Customer { Comments = "VIP" }); // true
```

# Equality Comparer

`EqualSpecification<T>` supports `IEqualityComparer<T>`.

```csharp
var spec = Specification.Equal<double>(
    0.0045, EqualityComparer<double>.Default);
```

# EF 6 support

`EqualSpecification<T>` works correctly in *EF 6* solution, when *T* is primitive or enum type.  
Non primitive types, may generate `NotSupportedException`.