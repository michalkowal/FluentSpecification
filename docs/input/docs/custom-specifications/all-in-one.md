Title: All in one
Description: Custom <i>Specification</i> with <code>IComplexSpecification&lt;T&gt;</code> usage.
Order: 400
---

"Last" interface in [`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) is `IComplexSpecification<T>`.  
This interface inerit from `IValidationSpecification<T>` and `ILinqSpecification<T>` and can be used as representation for "rich" *Specifications*.  
All built-in *Specifications* are "complex" and implements `IComplexSpecification<T>`.

```csharp
public class VipCustomerSpecification :
    IComplexSpecification<Customer>
{
    public bool IsSatisfiedBy(Customer candidate)
    {
        return candidate
            .Comments
            .Split(new char[] {';'})
            .Contains("Vip");
    }

    public bool IsSatisfiedBy(Customer candidate, out SpecificationResult result)
    {
        bool overall = IsSatisfiedBy(candidate);
        result = overall
            ? new SpecificationResult()
            : new SpecificationResult(false,
                new FailedSpecification(typeof(VipCustomerSpecification), candidate, "Customer is NOT VIP"));
        return overall;
    }

    public Expression<Func<Customer, bool>> GetExpression()
    {
        return candidate => IsSatisfiedBy(candidate);
    }

    Expression ILinqSpecification.GetExpression()
    {
        return GetExpression();
    }
}
```

## AsComplexSpecification

All *Specifications* can be converted to `IComplexSpecification<T>` by [`AsComplexSpecification`](/FluentSpecification/api/FluentSpecification.Core/Specification/479F235B) method.  
After conversion, created *Specification* supports `IValidationSpecification<T>` and `ILinqSpecification<T>`, regardless of whether the base *Specification* implements these interfaces.  
  
**BE AWARE!** As described in [Concept section](/FluentSpecification/docs/concept/core-specifications#everything-is-complex) *Linq expressions* produced in this way, will not work with *LinqToEntities* (`Ef 6` scenarios). In `EF Core` should works fine.  
For `EF 6`, `ILinqSpecification<T>` implementation with special *expressions* building is necessary. See [Linq Specification implementing](/FluentSpecification/docs/custom-specifications/linq-specification).

```csharp
// Simple Specification implementation
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

var vipCustomerSpec = new VipCustomerSpecification()
    .AsComplexSpecification();
var expression = vipCustomerSpec.GetExpression();	// You can do that!
```

# ComplexSpecification inheritance

In [`FluentSpecification.Core`](/FluentSpecification/api/FluentSpecification.Core/) package, there is a special `abstract class`, prepared for complex *Specifications* - `ComplexSpecification<T>`.  
Most of common built-in *Specifications* in [`FluentSpecification`](/FluentSpecification/api/FluentSpecification/) package, inherit from this class.  
`ComplexSpecification<T>` also implements *Negatable* interfaces.

```csharp
public class ExpiredCreditCardSpecification :
    ComplexSpecification<CreditCard>
{
    protected override string CreateFailedMessage(CreditCard candidate)
    {
        return "Credit card is NOT expired.";
    }

    protected override string CreateNegationFailedMessage(CreditCard candidate)
    {
        return "Credit card is expired.";
    }

    protected override Expression BuildExpressionBody(Expression parameter)
    {
        DateTime now = DateTime.Now;
        // We can't use lambda here
        return Expression.LessThan(
            Expression.Property(parameter, nameof(CreditCard.ValidityDate)),
            Expression.Constant(now, typeof(DateTime)));
    }
}

var expiredCardSpec = new ExpiredCreditCardSpecification();
var notExpiredCardSpec = expiredCardSpec.Not();

var expiredCard = new CreditCard
{
    ValidityDate = DateTime.Now.AddMonths(-1)
};
var notExpiredCard = new CreditCard
{
    ValidityDate = DateTime.Now.AddMonths(1)
};

expiredCardSpec.IsSatisfiedBy(expiredCard); // true
expiredCardSpec.IsSatisfiedBy(notExpiredCard, out var result1); // false
result1.ToString(); // Credit card is NOT expired.

notExpiredCardSpec.IsSatisfiedBy(notExpiredCard); // true
notExpiredCardSpec.IsSatisfiedBy(expiredCard, out var result2); // false
result2.ToString(); // Credit card is expired.
```

`ComplexSpecification<T>` creates *Lambda expression* himself, so you need to provide only *Expression body*.  
In above example, [`Expression parameter`](/FluentSpecification/api/FluentSpecification.Core/ComplexSpecification_1/475D60E6#Parameters) is lambda argument of type *CreditCard*. The name of argument is always *candidate*.

## Value types

There is also special method - [`BuildValueTypeExpressionBody`](/FluentSpecification/api/FluentSpecification.Core/ComplexSpecification_1/35102EE3). When *T* is value type and *Expression* should be different (for example in *LinqToEntities*) - override this method.  

**BE AWARE!** `Nullable` types, are handled as not value types.

```csharp
public sealed class NullSpecification<T> :
    ComplexSpecification<T>
{
    protected override string CreateFailedMessage(T candidate)
    {
        return "Object is not null";
    }

    protected override string CreateNegationFailedMessage(T candidate)
    {
        return "Object is null";
    }

    protected override Expression BuildValueTypeExpressionBody(Expression arg)
    {
        // ValueTypes are ALWAYS not null
        return Expression.Constant(false);
    }

    protected override Expression BuildExpressionBody(Expression arg)
    {
        // Check if candidate is null
        var expression = Expression.Equal(arg, Expression.Constant(null, typeof(T)));
        return expression;
    }
}
```