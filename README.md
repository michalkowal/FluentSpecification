[<img src="https://raw.githubusercontent.com/michalkowal/FluentSpecification/master/docs/input/assets/img/logo.png" alt="FluentSpecification" width="300px" />](https://michalkowal.github.io/FluentSpecification/)

[![Build status](https://img.shields.io/appveyor/ci/michalkowal/fluentspecification/master.svg?style=popout-square&logo=appveyor)](https://ci.appveyor.com/project/michalkowal/fluentspecification/branch/master)
[![NuGet](https://img.shields.io/nuget/v/FluentSpecification.svg?style=popout-square&logo=nuget&logoColor=%23017ddc)](https://www.nuget.org/packages/FluentSpecification)
[![Coverage Status](https://img.shields.io/coveralls/github/michalkowal/FluentSpecification/master.svg?style=popout-square&logo=codecov)](https://coveralls.io/github/michalkowal/FluentSpecification?branch=master)
[![Tests](https://img.shields.io/appveyor/tests/michalkowal/FluentSpecification/master.svg?style=popout-square&logo=appveyor)](https://ci.appveyor.com/project/michalkowal/fluentspecification/branch/master/tests)  

![.NET Standard 1.x](https://img.shields.io/badge/Standard-1.x-blue.svg?style=popout-square&logo=.net)
![.NET Standard 2.x](https://img.shields.io/badge/Standard-2.x-blue.svg?style=popout-square&logo=.net)
![.NET Core 1.x](https://img.shields.io/badge/Core-1.x-blue.svg?style=popout-square&logo=.net)
![.NET Core 2.x](https://img.shields.io/badge/Core-2.x-blue.svg?style=popout-square&logo=.net)
![.NET Framework 4.5+](https://img.shields.io/badge/Framework-4.5%2B-blue.svg?style=popout-square&logo=.net)

**FluentSpecification** is .NET implementation of *Specification design pattern* with many small, built-in reusable specifications, perfect for validation of *Domain Model* in *Domain-Driven-Design* approach and other similar, where system is built around domain objects.  
Other important features:
- **`Fluent API`** - allows to build and combine specifications in simple and clear way. 
- **`Built-in specifications`** - with validation and *Linq expression* support. Many of them available as negation
- **`Objects validation`** - special result with error messages, trace of all used specifications, specifications parameters etc. Can be used not only for domain, but also for DTOs and user input, when you need to log result or present it on UI.
- **`Linq expression`** - specifications can be used in collections querying. Business logic of repositories can be separated to specifications and use interchangeably.
- **`EF Core support`** - all specifications are tested with *EF Core* on real database and ca be used without errors.
- **`EF 6 partial support`** - many of specifications support *LinqToEntities* (*LinqToSql*) and can be used in *Entity Framework 6* queries.

[Full documentation](https://michalkowal.github.io/FluentSpecification/)

## Example

```csharp
using FluentSpecification;
using FluentSpecification.Core;

var customerSpec = Specification
    // Specify not null Customer
    .NotNull<Customer>()

    // with Id between 100 and 200
    .And()
    .InclusiveBetween(c => c.CustomerId, 100, 200)

    // and LastName is "Smith"
    .And()
    .Equal(c => c.LastName, "Smith")

    // and Customer is active
    .And()
    .True(c => c.IsActive)

    // and Customer property "Email" is ...
    .And(Specification.ForProperty<Customer, string>(c => c.Email, Specification
        // ... valid email
        .Email()

        // longer than 15 characters
        .And()
        .MinLength(15)

        // on "gmail.com"
        .And()
        .Match("^.*@gmail.com$")))

    // with not empty Item collection ...
    .And()
    .ForProperty(c => c.Items, Specification
        .NotEmpty<ICollection<Item>>()

        // ... contains Item '1000'
        .And()
        .Contains(new Item { ItemId = 1000 }))

    // and Customer has credit card ...
    .And()
    .NotNull(c => c.CreditCard)

    // ... with valid number
    .And()
    .CreditCard(c => c.CreditCard.CardNumber)

    // and credit card is valid between 2019-03-12 ...
    .And(Specification
        .GreaterThanOrEqual<Customer, DateTime>(c => c.CreditCard.ValidityDate, 
            new DateTime(2019, 3, 12))
        
        // ... and 2019-05-31
        .Or()
        .LessThan(c => c.CreditCard.ValidityDate, new DateTime(2019, 6, 1)));
```

#### Is satisfied by

```csharp
customerSpec.IsSatisfiedBy(new Customer
{
    CustomerId = 125,
    LastName = "Smith",
    IsActive = true,
    Email = "asmith@gmail.com",
    Items = new List<Item>()
    {
        new Item { ItemId= 1000 }
    },
    CreditCard = new CreditCard
    {
        CardNumber = "5500 0000 0000 0004",
        ValidityDate = DateTime.Parse("2019-03-12")
    }
}); // return true
```

#### Validation

```csharp
customerSpec.IsSatisfiedBy(new Customer
{
    CustomerId = 90,
    LastName = "Jones",
    IsActive = false,
    Email = "mjones@hotmail.com",
    Items = null,
    CreditCard = new CreditCard
    {
        CardNumber = "5500 0000 1",
        ValidityDate = DateTime.Parse("2019-03-01")
    }
}, out var specResult);    // return false

Console.WriteLine(specResult.ToString());
// Field 'CustomerId' value is not valid
// Field 'CustomerId': [Value is not between [100] and [200]]
// Field 'LastName' value is not valid
// Field 'LastName': [Object is not equal to [Smith]]
// Field 'IsActive' value is not valid
// Field 'IsActive': [Value is False]
// Field 'Email' value is not valid
// Field 'Email': [String not match pattern [^.*@gmail.com$]]
// Field 'Items' value is not valid
// Field 'Items': [Object is empty]
// Field 'Items': [Collection not contains [FluentSpecification.Integration.Tests.Data.Item]]
// Field 'CreditCard.CardNumber' value is not valid
// Field 'CreditCard.CardNumber': [Value is not correct credit card number]
```

#### Querying

```csharp
var customers = new List<Customer>()
{
    // fill customers
};
var result = customers
    .Where(customerSpec.AsPredicate()).ToList();

var dbResult = Context.Customers
    .Where(customerSpec.GetExpression()).ToList();    // Or customerSpec.AsExpression()
```

#### Translations / Custom messages

```csharp
// Single error message for whole specifications chain
customerSpec
    .WithMessage(c => $"Validation failed: Incorrect Customer - ID '{c.CustomerId}'")
    .IsSatisfiedBy(new Customer
    {
        CustomerId = 90,
        LastName = "Jones",
        IsActive = false,
        Email = "mjones@hotmail.com",
        Items = null,
        CreditCard = new CreditCard
        {
            CardNumber = "5500 0000 1",
            ValidityDate = DateTime.Parse("2019-03-01")
        }
    }, out var specResult);    // return false

Console.WriteLine(specResult.ToString());
// Validation failed: Incorrect Customer - ID '90'


// Custom messages for each specification
var idSpec = Specification
    .NotEmpty<Customer, int>(c => c.CustomerId)
    .WithMessage(c => $"Unknown Customer ID: '{c.CustomerId}'");

var activeSpec = Specification
    .True<Customer>(c => c.IsActive)
    .WithMessage("Customer is archived");

idSpec.And(activeSpec)
    .IsSatisfiedBy(new Customer(), out var specResult);    // return false

Console.WriteLine(specResult.ToString());
// Unknown Customer ID: '0'
// Customer is archived
```

## Built-in Specifications
- `And, AndNot` - join two specifications with logical AND
- `Or, OrNot` - join two specifications with logical OR
- `Not` - specification logical negation
- `ForProperty` - Verifies if Specification is satisfied by property value
- `Cast` - converts candidate to type
- `Expression` - use external Linq expression
- `True` - is boolean true
- `False` - is boolean false
- `Null, NotNull` - if object reference null
- `Empty, NotEmpty` - if object, string or collection empty
- `Equal, NotEqual` - equal to expected object
- `LessThan, LessThanOrEqual, NotLessThan, NotLessThanOrEqual` - less than expected value
- `GreaterThan, GreaterThanEqual, NotGreaterThan, NotGreaterThanEqual` - greater than expected value
- `InclusiveBetween, ExclusiveBetween, NotInclusiveBetween, NotExclusiveBetween` - is in range
- `Length, NotLength` - if length is equal to expected value
- `MinLength, NotMinLength` - if length is greater than expected value
- `MaxLength, NotMaxLength` - if length is lower than expected value
- `LengthBetween, NotLengthBetween` - if length is in range
- `Contains, NotContains` - is contain expected value
- `Email, NotEmail` - if candidate is valid email address
- `CreditCard, NotCreditCard` - if candidate is valid credit card number
- `Match, NotMatch` - match Regex pattern
- `All` - checks if all elements in collection is satisfied by specification
- `Any` - checks if any element in collection is satisfied by specification
- `IsType, IsNotType` - checks if candidate is specific type

## Packages

```
Install-Package FluentSpecification.Abstractions
```
Abstraction layer for **Specification design pattern**. Contains also interfaces and structures for validation and *Linq* scenarios.  
Commonly used types:
- `FluentSpecification.Abstractions.Generic.ISpecification<>`
- `FluentSpecification.Abstractions.Generic.IValidationSpecification<>`
- `FluentSpecification.Abstractions.Generic.ILinqSpecification<>`

```
Install-Package FluentSpecification.Core
```
Core implementation of **Specification design pattern**. Contains:
- Specifications composition (*And*, *Or*, *AndNot*, *OrNot*)
- Specifications negation with validation handling (error message negation, linq negation etc.)
- Error handling for validation scenarios
- Linq expressions composing

```
Install-Package FluentSpecification
```
Common implementation of small reusable Specifications. All Specifications are based on **Specification design pattern**. Specifications support validation scenarios and also can be used like *Linq* expressions, because they are designed and implemented especially for *Entity Framework Core* support and partially for *Entity Framework 6* and tested with these frameworks.

[![License](https://img.shields.io/github/license/michalkowal/FluentSpecification.svg?style=popout-square&logo=apache&logoColor=%23D22128)](https://github.com/michalkowal/FluentSpecification/blob/master/LICENSE)