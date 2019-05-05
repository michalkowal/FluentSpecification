Description: Join <i>Specifications</i> as logical AND.
Order: 100
DisplayDescription: true
Support: Full;Full;Full;Full
---

# Usage (A && B)

```csharp
Specification
    .True()
    .And()
    .True()
    .IsSatisfiedBy(true);   // true

Specification
    .True()
    .And()
    .False()
    .IsSatisfiedBy(true);   // false

Specification
    .False()
    .And()
    .False()
    .IsSatisfiedBy(true);   // false
```

## Multiple composition ways

Below all examples, generate the same result.

```csharp
Specification
    .NotNull<string>()
    .And()
    .NotEmail();

Specification
    .NotNull<string>()
    .And(Specification
        .Email());

// Create EmailSpecification with parameter-less constructor
Specification
    .NotNull<string>()
    .And<string, EmailSpecification>();
```

## Grouping

### A && (B || C)

```csharp
Specification
    .NotEmpty<string>()
    .And(Specification
        .Contains("lorem")
        .Or()
        .Contains("ipsum"));
```

### (A || B) && C

```csharp
Specification
    .And(Specification
            .Contains("lorem")
            .Or()
            .Contains("ipsum"), 
        Specification
            .NotEmpty<string>());
```

### (A || B) && (C || D)

```csharp
Specification
    .And(Specification
            .Length<string>(3)
            .Or()
            .MinLength(10),
        Specification
            .Contains("lorem")
            .Or()
            .Contains("ipsum"));
```

# And Not (A && !B)

```chsarp
Specification
    .True()
    .AndNot()
    .True()
    .IsSatisfiedBy(true);   // false

Specification
    .True()
    .AndNot()
    .False()
    .IsSatisfiedBy(true);   // true

Specification
    .False()
    .AndNot()
    .False()
    .IsSatisfiedBy(true);   // false
```

## Grouping

### A && !(B || C)

```csharp
Specification
    .NotEmpty<string>()
    .AndNot(Specification
        .Contains("lorem")
        .Or()
        .Contains("ipsum"));
```

### (A || B) && !C

```csharp
Specification
    .AndNot(Specification
            .Contains("lorem")
            .Or()
            .Contains("ipsum"), 
        Specification
            .NotEmpty<string>());
```

### (A || B) && !(C || D)

```csharp
Specification
    .AndNot(Specification
            .Length<string>(3)
            .Or()
            .MinLength(10),
        Specification
            .Contains("lorem")
            .Or()
            .Contains("ipsum"));
```