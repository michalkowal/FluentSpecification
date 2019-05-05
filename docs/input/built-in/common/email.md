Description: Checks if string is valid email address.
Order: 1800
DisplayDescription: true
Support: Full;Full;Full;None
ValidationError: <i>"String is invalid email"</i>.;<i>"String is valid email"</i> - for negation.
---

# Usage

```csharp
var spec = Specification.Email();

spec.IsSatisfiedBy("john.doe@gmail.com");   // true
spec.IsSatisfiedBy("email.example.com");    // false
spec.IsSatisfiedBy(null);    // false
```

## As property

```csharp
var customerSpec = Specification.Email<Customer>(c => c.Email);

customerSpec.IsSatisfiedBy(new Customer { Email = "john.doe@gmail.com" });   // true
customerSpec.IsSatisfiedBy(new Customer { Email = "email.example.com" });    // false
customerSpec.IsSatisfiedBy(new Customer { Email = null });    // false
```

# Not Email

```csharp
var spec = Specification.NotEmail();

spec.IsSatisfiedBy("john.doe@gmail.com");   // false
spec.IsSatisfiedBy("email.example.com");    // true
spec.IsSatisfiedBy(null);    // true
```

## As property

```csharp
var customerSpec = Specification.NotEmail<Customer>(c => c.Email);

customerSpec.IsSatisfiedBy(new Customer { Email = "john.doe@gmail.com" });   // false
customerSpec.IsSatisfiedBy(new Customer { Email = "email.example.com" });    // true
customerSpec.IsSatisfiedBy(new Customer { Email = null });    // true
```

# EF 6 support

Right now `EmailSpecification` uses `Regex` for verification - it is not supported in *LinqToEntities* (*LinqToSql*).