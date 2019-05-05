Description: Custom <i>Specification</i> implementation for <i>Linq</i>.
Order: 300
---

For *Linq* scenarios, use `ILinqSpecification<T>` interface from [`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) package.  
`ILinqSpecification<T>` inherit from `ISpecification<T>`.

```csharp
public class ExpiredCreditCardSpecification :
    ILinqSpecification<CreditCard>
{
    public Expression<Func<CreditCard, bool>> GetExpression()
    {
        DateTime now = DateTime.Now;
        return creditCard => creditCard.ValidityDate < now;
    }

    Expression ILinqSpecification.GetExpression()
    {
        return GetExpression();
    }

    public bool IsSatisfiedBy(CreditCard candidate)
    {
        return GetExpression().Compile().Invoke(candidate);
    }
}
```

You don't need to use *Expression* in [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D) method, but it's highly recommended to provide the same result here and here.