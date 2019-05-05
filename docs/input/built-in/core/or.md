Description: Join <i>Specifications</i> as logical OR.
Order: 200
DisplayDescription: true
Support: Full;Full;Full;Full
---

# Usage (A || B)

```csharp
Specification
    .True()
    .Or()
    .True()
    .IsSatisfiedBy(true);   // true

Specification
    .True()
    .Or()
    .False()
    .IsSatisfiedBy(true);   // true

Specification
    .False()
    .Or()
    .False()
    .IsSatisfiedBy(true);   // false
```

Below all examples, generate the same result.

```csharp
Specification
    .NotNull<string>()
    .Or()
    .NotEmail();

Specification
    .NotNull<string>()
    .Or(Specification
        .Email());

// Create EmailSpecification with parameter-less constructor
Specification
    .NotNull<string>()
    .Or<string, EmailSpecification>();
```

## Grouping

### A || (B && C)

```csharp
Specification
    .NotEmpty<string>()
    .Or(Specification
        .Contains("lorem")
        .And()
        .Contains("ipsum"));
```

### (A && B) || C

```csharp
Specification
    .Or(Specification
            .Contains("lorem")
            .And()
            .Contains("ipsum"), 
        Specification
            .NotEmpty<string>());
```

### (A && B) || (C && D)

```csharp
Specification
    .Or(Specification
            .NotEmpty<string>()
            .And()
            .Length(10),
        Specification
            .Contains("lorem")
            .And()
            .Contains("ipsum"));
```

# Or Not (A || !B)

```chsarp
Specification
    .True()
    .OrNot()
    .True()
    .IsSatisfiedBy(true);   // true

Specification
    .False()
    .OrNot()
    .True()
    .IsSatisfiedBy(true);   // false

Specification
    .False()
    .OrNot()
    .False()
    .IsSatisfiedBy(true);   // true
```

## Grouping

### A || !(B && C)

```csharp
Specification
    .NotEmpty<string>()
    .OrNot(Specification
        .Contains("lorem")
        .And()
        .Contains("ipsum"));
```

### (A && B) || !C

```csharp
Specification
    .OrNot(Specification
            .Contains("lorem")
            .And()
            .Contains("ipsum"), 
        Specification
            .NotEmpty<string>());
```

### (A && B) || !(C && D)

```csharp
Specification
    .OrNot(Specification
            .NotEmpty<string>()
            .And()
            .Length(10),
        Specification
            .Contains("lorem")
            .And()
            .Contains("ipsum"));
```