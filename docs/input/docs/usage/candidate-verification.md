Description: How to check, if <i>Specification</i> is satisfied by candidate. Describes also <i>Validation</i> and <i>Linq</i> scenarios.
Order: 300
---

Finally, prepared *Specification* can be used for objects verification.  
According to pattern, base method is [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D).

```csharp
// All array elements must be greater than 0
var allGreaterThanSpec = Specification
    .All<int[], int>(Specification
        .GreaterThan(0));

var result = allGreaterThanSpec
    .IsSatisfiedBy(new[] {1, 2, 10, 15, 123});  // true
```

## AsPredicate

All *Specifications* can be transform to `Func<T, bool>` with [`AsPredicate`](/FluentSpecification/api/FluentSpecification.Core/Specification/05EB1639) extension method.

```csharp
var greaterThanSpec = Specification
    .GreaterThan(0);

var result = new[] {-1, 2, 0, 15, -123}
    .Where(greaterThanSpec.AsPredicate())
    .ToArray(); // int[2] { 2, 15 }
```

## Func<T, bool> operator

All *built-in Specifications* contains `implicit Func<T, bool>` operator.

```csharp
var greaterThanSpec = 
    new GreaterThanSpecification<int>(0);

new[] {-1, 2, 0, 15, -123}
    .Where(greaterThanSpec);
```

# Validation

*Specifications* that they implement `IValidationSpecification<T>` interface, can be used in validation scenarios.

```csharp
// All array elements must be greater than 0
var allGreaterThanSpec = Specification
    .All<int[], int>(Specification
        .GreaterThan(0));

var overall = allGreaterThanSpec
    .IsSatisfiedBy(new[] { -1, 2, 0, 15, -123 }, out var result);  // false

result.ToString();
// One or more elements are not specified
// [0] Object is lower than or equal to[0]
// [2] Object is lower than or equal to[0]
// [4] Object is lower than or equal to[0]
```

Full content of `SpecificationResult` object is described in [Concept section](/FluentSpecification/docs/concept/validation-result).

# Linq

`ILinqSpecification<T>` types, can be used as *Linq expressions*, using [`GetExpression`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ILinqSpecification_1/24066042) method.

```csharp
// Find Mr. Smith
ILinqSpecification<Customer> spec = Specification
    .Equal<Customer, string>(c => c.LastName, "Smith");

using (var ctx = new EfCoreDbContext())
{
    var customer = ctx
        .Customers
        .FirstOrDefault(spec.GetExpression());
}
```

## AsExpression

Every *Specification* can be converted to *Linq expression* with [`AsExpression`](/FluentSpecification/api/FluentSpecification.Core/Specification/943F4DF7) extension method.  
*Specification* that they not implement `ILinqSpecification<T>` interface, can be converted by [SpecificationAdapter](//FluentSpecification/docs/concept/core-specifications#everything-is-complex) class.

```csharp
public class VipCustomerSpecification :
    ISpecification<Customer>
{
    public bool IsSatisfiedBy(Customer candidate)
    {
        return candidate
            .Comments
            .Split(new char[] {';'})
            .Contains("Vip");
    }
}

// Find VIPs
var vipSpec = new VipCustomerSpecification();

using (var ctx = new EfCoreDbContext())
{
    var customer = ctx
        .Customers
        .Where(vipSpec.AsExpression());
}
```

**BE AWARE** Some *Specifications* converted by [`AsExpression`](/FluentSpecification/api/FluentSpecification.Core/Specification/943F4DF7), may cause exceptions when using *LinqToEntities* (*LinqToSql*).  
More information in [EF support section](/FluentSpecification/docs/concept/entity-framework-support).

## Expression operator

All *built-in Specifications* contains `implicit Expression<Func<T, bool>>` operator and `explicit Expression` operator.

```csharp
var validEmailSpec = new EmailSpecification();

Expression<Func<string, bool>> expression = validEmailSpec;
Expression baseExpression = (Expression) validEmailSpec;
```

## LinqToEntities

As mentioned above, some *Specifications* are not working at all with *LinqToEntities* (eg *Specifications* with Regex - Match, Email, CreditCard).  
Some *Specifications* support partially *LinqToEntities*. These specifications, usually has special `linqToEntities` flag.

```csharp
// Specification check if collection is null or empty.
var notEmptyItemsSpec = Specification
    .NotEmpty<Customer, ICollection<Item>>(c => c.Items);
var notEmptyItemsSpecEFSupport = Specification
    .ForProperty<Customer, ICollection<Item>>(c => c.Items,
        // Specification do not check if collection is null. Only if empty.
        new EmptySpecification<ICollection<Item>>(linqToEntities: true).Not());

using (var ctx = new EfDbContext())
{
    var customer = ctx
        .Customers
        // NotSupportedException: Only primitive types, enumeration types and entity types are supported.
        //.Where(notEmptyItemsSpec.GetExpression()).ToArray();

        // Without Exception!
        .Where(notEmptyItemsSpecEFSupport.GetExpression()).ToArray();
}
```

*Fluent API* is prepared for global *LinqToEntities* support:
`Specification.LinqToEntities` flag should be set to *true*.  
After that, all *Specifications* with `linqToEntities` support, are built with this flag.

```csharp
// Unblock 'LinqToEntities' support globally.
Specification.LinqToEntities = true;

var notEmptyItemsSpec = Specification
    .NotEmpty<Customer, ICollection<Item>>(c => c.Items);

using (var ctx = new EfDbContext())
{
    var customer = ctx
        .Customers
        // Without Exception!
        .Where(notEmptyItemsSpec.GetExpression()).ToArray();
}
```

`Specification.LinqToEntities` flag can be set back to false in any time, 
but after that, every *Specification* will be built without *LinqToEntities* support. 