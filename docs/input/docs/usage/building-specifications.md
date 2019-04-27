Description: How <i>Specifications</i> can be build, with or without <i>Fluent API</i>.
Order: 200
---

*Specifications* can be build by *Fluent API* or by normal *constructors*, because all *built-in Specifications* are public to use.

# Constructors

Built-in *Specifications* are available in two namespaces:
- **`FluentSpecification.Core.Composite`** - core *Specifications* for composition (like And, Or etc.).
- **`FluentSpecification.Common`** - other common *Specifications* (like Empty, Equal, Null etc.).

```csharp
var trueSpec = new TrueSpecification();
var emptyStringSpec = new EmptySpecification<string>();

// Create 'Customer' specification for 'IsActive' property and use TrueSpecification -
// 'IsActive' must be true
var activeSpec = new PropertySpecification<Customer, bool>(
    c => c.IsActive, trueSpec);
// Create 'Customer' specification for 'Comments' property and use EmptySpecification -
// 'Comments' must be null or string.Empty
var commentsSpec = new PropertySpecification<Customer, string>(
    c => c.Comments, emptyStringSpec);

// Compose previous 'Customer' specifications
var andSpec = new AndSpecification<Customer>(activeSpec, commentsSpec);
```

# Fluent API

All *built-in Specifications* have set of extensions for `ISpecification<T>` interface, and can be used fluently.

```csharp
var trueSpec = new TrueSpecification();
var notEmptyStringSpec = new EmptySpecification<string>()
    .Not();

// Create 'Customer' specification for 'IsActive' property and use TrueSpecification -
// 'IsActive' must be true
var activeSpec = new PropertySpecification<Customer, bool>(
    c => c.IsActive, trueSpec);
// Create 'Customer' specification for 'Comments' property and use EmptySpecification -
// 'Comments' must be NOT null or NOT string.Empty
var commentsSpec = new PropertySpecification<Customer, string>(
    c => c.Comments, notEmptyStringSpec);

// Compose previous 'Customer' specifications
var andSpec = activeSpec
    .And(commentsSpec);
```

## Entry point

To prevent use constructors, there is a special *static class* [`Specification`](/FluentSpecification/api/FluentSpecification/Specification/) in [`FluentSpecification`](/FluentSpecification/api/FluentSpecification/) namespaces, and this is formall "entry point".  
[`Specification`](/FluentSpecification/api/FluentSpecification/Specification/) contains creation methods for all *built-in Specifications* and also negations for some of them.

```csharp
// Previous examples in flatten version
var finalSpec = Specification
    .True<Customer>(c => c.IsActive)
    .And()
    .NotEmpty(c => c.Comments);
```