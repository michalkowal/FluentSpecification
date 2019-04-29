Description: Checks if string candidate match a given <i>Regex</i> pattern.
Order: 2000
DisplayDescription: true
Support: Full;Full;Full;None
---

# Usage

```csharp
var spec = Specification.Match("^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$");

spec.IsSatisfiedBy("2019-02-26");   // true
spec.IsSatisfiedBy("2019/02/26");    // false
spec.IsSatisfiedBy(null);    // false
```

## As property

```csharp
var customerSpec = Specification.Match<Customer>(c => c.Email, "^.*@email.com$");

customerSpec.IsSatisfiedBy(new Customer { Email = "john.doe@email.com" });   // true
customerSpec.IsSatisfiedBy(new Customer { Email = "jd@gmail.com" });    // false
customerSpec.IsSatisfiedBy(new Customer { Email = null });    // false
```

# Not Match

```csharp
var spec = Specification.NotMatch("^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$");

spec.IsSatisfiedBy("2019-02-26");   // false
spec.IsSatisfiedBy("2019/02/26");    // true
spec.IsSatisfiedBy(null);    // true
```

## As property

```csharp
var customerSpec = Specification.NotMatch<Customer>(c => c.Email, "^.*@email.com$");

customerSpec.IsSatisfiedBy(new Customer { Email = "john.doe@email.com" });   // false
customerSpec.IsSatisfiedBy(new Customer { Email = "jd@gmail.com" });    // true
customerSpec.IsSatisfiedBy(new Customer { Email = null });    // true
```

# EF 6 support

Right now `MatchSpecification` uses `Regex` for verification - it is not supported in *LinqToEntities* (*LinqToSql*).