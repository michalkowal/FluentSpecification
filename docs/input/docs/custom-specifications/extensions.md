Title: Fluent API extensions
Description: How to create custom extensions to <i>Fluent API</i>.
Order: 500
---

Every custom *Specification* can be "plugged-in" to *Fluent API*. Special extensions are needed for this.
We will use `ExpiredCreditCardSpecification` from [previous example](/FluentSpecification/docs/custom-specifications/all-in-one).

```csharp
public static IComplexSpecification<CreditCard> ExpiredCreditCard(this ICompositeSpecification<CreditCard> self)
{
    return self.Compose(new ExpiredCreditCardSpecification());
}

public static IComplexSpecification<CreditCard> NotExpiredCreditCard(this ICompositeSpecification<CreditCard> self)
{
    return self.Compose(new ExpiredCreditCardSpecification().Not());
}

var creditCardSpec1 = Specification
    .Null<CreditCard>()
    .Or()
    .ExpiredCreditCard();
var creditCardSpec2 = Specification
    .NotNull<CreditCard>()
    .And()
    .NotExpiredCreditCard();
```

`ICompositeSpecification<T>` interface represents *FluentApi* [`And`](/FluentSpecification/api/FluentSpecification.Core/Specification/55825F3F), [`AndNot`](/FluentSpecification/api/FluentSpecification.Core/Specification/1133FDA0), [`Or`](/FluentSpecification/api/FluentSpecification.Core/Specification/5482974F), [`OrNot`](/FluentSpecification/api/FluentSpecification.Core/Specification/D4138034) methods. 
[`Compose`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ICompositeSpecification_1/D931576B) method create specific *composite Specification*.  

Unfortunately [`Specification`](/FluentSpecification/api/FluentSpecification/Specification/) class is static, so custom specification cannot be created in this way right now.

## Extensions for properties

If you intend to use CreditCard as property in other type, you can also provide extensions with property selectors.

```csharp
public static IComplexSpecification<T> ExpiredCreditCard<T>(this ICompositeSpecification<T> self,
    Expression<Func<T, CreditCard>> selector)
{
    return self.Compose(Specification.ForProperty(selector,
        new ExpiredCreditCardSpecification()));
}

public static IComplexSpecification<T> NotExpiredCreditCard<T>(this ICompositeSpecification<T> self,
    Expression<Func<T, CreditCard>> selector)
{
    return self.Compose(Specification.ForProperty(selector,
        new ExpiredCreditCardSpecification().Not()));
}

var customerSpec1 = Specification
    .NotNull<Customer>()
    .And()
    .ExpiredCreditCard(c => c.CreditCard);
var customerSpec2 = Specification
    .Null<Customer>()
    .Or()
    .NotExpiredCreditCard(c => c.CreditCard);
```