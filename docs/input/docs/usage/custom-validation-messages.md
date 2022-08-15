Description: How to customize or translate <i>Validation</i> messages when <i>Specification</i> is not satisfied by candidate.
Order: 400
---

# WithMessage

Every *Specification* that implements `ISpecification<T>` interface, can be assigned custom validation error message.  
To do that [`WithMessage`](/FluentSpecification/api/FluentSpecification.Core/Specification/F70EB3F8) extension method can be used.  
**BE AWARE!** If *Specification* implements `IValidationSpecification<T>` interface, *WithMessage* method will override error message by provided parameter.

## Const message

```csharp
var customerSpec = Specification
    .NotNull<Customer>()
    .WithMessage("Customer not found");

var overall = customerSpec
    .IsSatisfiedBy(null, out var result);  // false
	
result.ToString();
// "Customer not found" instead of "Object is null"
```

## Message based on candidate object

```csharp
var emailSpec = Specification
    .Email<Customer>()
    .WithMessage(c => $"Incorrect email: '{c.Email}'");

var overall = emailSpec
    .IsSatisfiedBy(new Customer
	{
	   Email = "lorem ipsum"
	}, out var result);  // false
	
result.ToString();
// "Incorrect email: 'lorem ipsum'"
```

## Message based on candidate object and specification parameters

*Specifications* which based on `ValidationSpecification<T>`, could provide information about additional parameters used during validation.  
To do that, *Specification* has to override [`GetParameters`](/FluentSpecification/api/FluentSpecification.Core/ValidationSpecification_1/5F755E39).  
Then, validation message could be customized based on this parameters.  

If *Specification* is not based on `ValidationSpecification<T>` but implement `IValidationSpecification<T>`, additional parameters could be provide with `SpecificationResult` during validation
([`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/IValidationSpecification_1/DCBDBED1)).  
`FailedSpecification` brings specific constructor with additional parameters: [`ctor`](/FluentSpecification/api/FluentSpecification.Abstractions.Validation/FailedSpecification/ECA19D55).  

Many of built-in *Specifications* provide additional parameters e.q. [`MaxLength`](/FluentSpecification/built-in/common/max-length#parameters):

```csharp
var lengthSpec = Specification
    .MaxLength<string>(10)
    .WithMessage((c, p) => $"Value cannot be longer than {p["MaxLength"]} characters. Specified value is {c.Length} characters long.");

var overall = lengthSpec
    .IsSatisfiedBy("lorem ipsum", out var result);  // false
	
result.ToString();
// "Value cannot be longer than 10 characters. Specified value is 11 characters long."
```

If there is more than one *Specification* in chain, parameters will be marge into single Dictionary.  

```chsarp
var lengthSpec = Specification
    .MinLength<string>(3)
    .And()
    .MaxLength(10)    // Equivalent of "InclusiveBetweenSpecification"
    .WithMessage((c, p) => $"Value length must be between {p["MinLength"]} and {p["MaxLength"]} characters");
```

When multiple *Specifications* provide parameter with the same key:
- if values of parameter are equal, then only single unique value is used
- if values are different, all unique values is stored as array

```csharp
var customerSpec = Specification
    .MinLength<Customer, string>(c => c.FirstName, 3)
    .And()
    .MinLength(c => c.LastName, 3)
    .WithMessage((c, p) => $"FirstName and LastName must be greater than {p["MinLength"]}");    // MinLength is 3
	
var lengthSpec = Specification
    .MinLength<string>(3)
    .And()
    .MinLength(10)
    .WithMessage((c, p) => $"Value should be longer than {((object[])p["MinLength"]).Cast<int>().Max()} characters"});
```

**BE AWARE!** Dictionary contains only parameters from failed *Specifications*:

```csharp
var lengthSpec = Specification
    .MinLength<string>(3)
    .And()
    .MaxLength(10)
    .WithMessage((c, p) => $"Value length must be between {p["MinLength"]} and {p["MaxLength"]} characters");
	
lengthSpec.IsSatisfiedBy("lorem ipsum", out var result);
// "KeyNotFoundException" because MinLengthSpecification "is satisfied"
```

In this case, function that provide custom message should be enhanced with parameters check.

# Examples

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
