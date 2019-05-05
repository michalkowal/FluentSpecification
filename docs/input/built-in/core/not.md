Description: Logical NOT <i>Specification</i> implementation.
Order: 300
DisplayDescription: true
Support: Full;Full;Full;Full
---

# Usage

```csharp
var spec = Specification
    .Empty<string>();
var negation = spec.Not();
    
// Empty
spec.IsSatisfiedBy("");    // true
spec.IsSatisfiedBy("lorem ipsum");    // false

// NOT empty
negation.IsSatisfiedBy("");    // false
negation.IsSatisfiedBy("lorem ipsum");    // true
```

## Multiple negation ways

Below all three examples, generate the same result.

```csharp
Specification
    .NotNull<string>()
    .And()
    .NotEmail();

Specification
    .NotNull<string>()
    .And(Specification
        .Email()
        .Not());

Specification
    .NotNull<string>()
    .AndNot()
    .Email();
```

## Negatable interfaces

All *Specifications* can be negated by `NotSpecification<T>`. Then result of specification is simple *logical negation*.  
Sometimes, when special negation hadling is needed (for example - validation and different error message for negation),
there is couple of special interfaces for negation, in [`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) package.  
Every *NegatableSpecification* interface is similar to normal *Specification* interface.  
Below example describes how it works.

```csharp
// ExpressionSpecification NOT implement INegatableValidationSpecification
var expSpec = Specification.Expression<bool>(b => b);

SpecificationResult result;
// return false with error: Specification doesn't meet expression: [b => b]
expSpec.IsSatisfiedBy(false, out result);
// return false without error message
expSpec.Not().IsSatisfiedBy(true, out result);

// NullSpecification implements INegatableValidationSpecification
var nullSpec = Specification.Null<string>();

// return false with error: Object is not null
nullSpec.IsSatisfiedBy("", out result);
// return false with error: Object is null
nullSpec.Not().IsSatisfiedBy(null, out result);
```