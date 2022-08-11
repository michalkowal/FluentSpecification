Description: How to customize or translate <i>Validation</i> messages when <i>Specification</i> is not satisfied by candidate.
Order: 400
---

# WithMessage

Every *Specification* that implements `ISpecification<T>` interface, can be assigned custom validation error message.  
To do that [`WithMessage`](/FluentSpecification/api/FluentSpecification.Core/Specification/F70EB3F8) extension method can be used.  
**BE AWARE!** If *Specification* implements `IValidationSpecification<T>` interface, *WithMessage* method will override error message by provided parameter.

```csharp
var customerSpec = Specification
    .NotNull<Customer>()
    .WithMessage("Customer not found");

var overall = customerSpec
    .IsSatisfiedBy(null, out var result);  // false
	
result.ToString();
// "Customer not found" instead of "Object is null"
```

## Customize specifications error messages

Validation error messages could be provided for every single *Specification* and use together in a chain:

```csharp
var idSpec = Specification
    .NotEmpty<Customer, int>(c => c.CustomerId)
    .WithMessage("Unknown Customer ID");

var activeSpec = Specification
    .True<Customer>(c => c.IsActive)
    .WithMessage("Customer is archived");
	
var emailSpec = Specification
    .Email<Customer>(c => c.Email)
    .WithMessage("Incorrect Customer email address");
	
var overall = idSpec
    .And(activeSpec)
    .And(emailSpec)
    .IsSatisfiedBy(new Customer(), out var result);    // return false

result.ToString();
// Unknown Customer ID
// Customer is archived
// Incorrect Customer email address
```

## Single error message for specifications chain

Multiple *Specifications* in a chain, could have single error message for whole group:

```csharp
var customerSpec = Specification
    .NotNull<Customer>()
    .And()
    .NotEmpty(c => c.CustomerId)
    .And()
    .True(c => c.IsActive)
    .And()
    .Email(c => c.Email)
    .WithMessage("Validation failed: Incorrect Customer");
	
var overall = customerSpec
    .IsSatisfiedBy(new Customer(), out var result);    // return false

result.ToString();
// Validation failed: Incorrect Customer
```

## Fluent API awareness

In fluent API *WithMessage* invocation, override all others custom messages declared before:

```csharp
var customerSpec = Specification
    .NotNull<Customer>()
    .And()
    .GreaterThan(c => c.CustomerId, 0)
    .And()
    .LessThan(c => c.CustomerId, 10000)
    .WithMessage("Incorrect Customer ID")
    .And()
    .NotEmpty(c => c.FirstName)
    .And()
    .NotEmpty(c => c.LastName)
    .And()
    .Email(c => c.Email)
    .WithMessage("Missing Customer data")
    .And()
    .True(c => c.IsActive)
    .WithMessage("Customer is archived");
	
var overall = customerSpec
    .IsSatisfiedBy(new Customer
    {
        CustomerId = 0,
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@mail.com",
        IsActive = true
    }, out var result);    // return false

result.ToString();
// "Customer is archived" - ouch !!! We expected "Incorrect Customer ID"
```

In case presented above, specifications with correct validation messages, should be defined in groups:

```csharp
var customerSpec = Specification
    .NotNull<Customer>();

var idSpec = Specification
    .GreaterThan<Customer, int>(c => c.CustomerId, 0)
    .And()
    .LessThan(c => c.CustomerId, 10000)
    .WithMessage("Incorrect Customer ID");

var dataSpec = Specification
    .NotEmpty<Customer, string>(c => c.FirstName)
    .And()
    .NotEmpty(c => c.LastName)
    .And()
    .Email(c => c.Email)
    .WithMessage("Missing Customer data");

var activeSpec = Specification
    .True<Customer>(c => c.IsActive)
    .WithMessage("Customer is archived");
	
var overall = customerSpec
    .And(idSpec)
    .And(dataSpec)
    .And(activeSpec)
    .IsSatisfiedBy(new Customer
    {
        CustomerId = 0,
        FirstName = "John",
        LastName = "Doe",
        Email = "john.doe@mail.com",
        IsActive = true
    }, out var result);    // return false

result.ToString();
// "Incorrect Customer ID" - good!
```
