Description: Special negation handling for custom <i>Specifications</i>.
Order: 300
---

All *Specifications* can be negated by `NotSpecification<T>`. Then result of specification is simple *logical negation*.  
Sometimes, when special negation hadling is needed (for example - validation and different error message for negation),
there is couple of special interfaces for negation, in [`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) package.  
Every *NegatableSpecification* interface is similar to normal *Specification* interface.  

**BE AWARE!** All *NegatableSpecification* interfaces, not inherit from `ISpecification<T>`. When you want to use *NegatableSpecification* with other *Specifications* - 
implement also `ISpecification<T>` interface.  

`NotSpecification<T>` is specially designed to use [`IsNotSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/INegatableSpecification_1/BCA1F315) and [`GetNegationExpression`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/INegatableLinqSpecification_1/73522998) for *Specifications* implement *Negatable* interfaces, instead of simple negation.

```csharp
public class VipCustomerSpecification :
    IComplexSpecification<Customer>,
    INegatableValidationSpecification<Customer>,
    INegatableLinqSpecification<Customer>
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

    public bool IsNotSatisfiedBy(Customer candidate)
    {
        // return simple negation...
        return !IsSatisfiedBy(candidate);
    }

    public bool IsNotSatisfiedBy(Customer candidate, out SpecificationResult result)
    {
        bool overall = IsNotSatisfiedBy(candidate);
        result = overall
            ? new SpecificationResult()
            // Error message here -> Customer is VIP, and we don't want to
            : new SpecificationResult(false,
                new FailedSpecification(typeof(VipCustomerSpecification), candidate, "Customer is VIP"));
        return overall;
    }

    public Expression<Func<Customer, bool>> GetNegationExpression()
    {
        return candidate => IsNotSatisfiedBy(candidate);
    }
}
```

# NegatableValidationSpecification inheritance

In [`FluentSpecification.Core`](/FluentSpecification/api/FluentSpecification.Core/) package there is special `abstract class` - `NegatableValidationSpecification<T>`.  
This class inherit from `ValidationSpecification<T>`, so provide all `IValidationSpecification<T>` functionalities.  
When you only want to provide custom error message for negation, this is the best solution.

```csharp
public class ItemDiscountSpecification :
    NegatableValidationSpecification<Item>
{
    public override bool IsSatisfiedBy(Item candidate)
    {
        return candidate.Paid == false &&
               candidate.Name.StartsWith("Sale") &&
               candidate.Price < 20.0;
    }

    protected override string CreateFailedMessage(Item candidate)
    {
        return $"Item [{candidate.Name}] is NOT 'discountable'.";
    }

    protected override string CreateNegationFailedMessage(Item candidate)
    {
        // Item is discountable and we don't want to
        return $"Item [{candidate.Name}] is 'discountable'.";
    }
}

var discountSpec = new ItemDiscountSpecification();
var notDiscountSpec = discountSpec.Not();

var discountableItem = new Item
{
    Paid = false,
    Name = "Sale Item - summer",
    Price = 5.99
};
var notDiscountableItem = new Item
{
    Paid = true,
    Name = "Super Item"
};

discountSpec.IsSatisfiedBy(notDiscountableItem, out var result1);
notDiscountSpec.IsSatisfiedBy(discountableItem, out var result2);

result1.ToString();
// Item [Super Item] is NOT 'discountable'.
result2.ToString();
// Item [Sale Item - summer] is 'discountable'.
```