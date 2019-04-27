Description: Custom <i>Specification</i> implementation for validation scenarios.
Order: 200
---

For more complex, validation scenarios, there is `IValidationSpecification<T>` interface from [`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) package.  
`IValidationSpecification<T>` inherit from `ISpecification<T>`.

```csharp
public class ItemDiscountSpecification :
    IValidationSpecification<Item>
{
    public bool IsSatisfiedBy(Item candidate)
    {
        return candidate.Paid == false &&
               candidate.Name.StartsWith("Sale") &&
               candidate.Price < 20.0;
    }

    public bool IsSatisfiedBy(Item candidate, out SpecificationResult result)
    {
        bool overall = IsSatisfiedBy(candidate);

        if (overall)
        {
            result = new SpecificationResult();
        }
        else
        {
            result = new SpecificationResult(false, 
                new FailedSpecification(typeof(ItemDiscountSpecification), 
                    candidate, "Item is not 'discountable'."));
        }

        return overall;
    }
}
```

It's good practice to provide `FailedSpecification` object, when overall *Specification* result is false.

# ValidationSpecification inheritance

In [`FluentSpecification.Core`](/FluentSpecification/api/FluentSpecification.Core/) package there is a special `abstract class` - `ValidationSpecification<T>`.

```csharp
public class ItemDiscountSpecification :
    ValidationSpecification<Item>
{
    public override bool IsSatisfiedBy(Item candidate)
    {
        return candidate.Paid == false &&
               candidate.Name.StartsWith("Sale") &&
               candidate.Price < 20.0;
    }

    protected override string CreateFailedMessage(Item candidate)
    {
        return $"Item [{candidate.Name}] is not 'discountable'.";
    }
}
```

Base class will provide proper `SpecificationResult` object, depends on [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D) result.  
When your *Specification* use some externall parameters, you can return them from [`GetParameters`](/FluentSpecification/api/FluentSpecification.Core/ValidationSpecification_1/5F755E39) method. This parameters will be passed to `SpecificationResult` object.

```csharp
public class ItemDiscountSpecification :
    NegatableValidationSpecification<Item>
{
    private readonly double _itemPrice;

    public ItemDiscountSpecification(double itemPrice)
    {
        _itemPrice = itemPrice;
    }

    public override bool IsSatisfiedBy(Item candidate)
    {
        return candidate.Paid == false &&
               candidate.Name.StartsWith("Sale") &&
               candidate.Price < _itemPrice;
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

    protected override IReadOnlyDictionary<string, object> GetParameters()
    {
        return new Dictionary<string, object>
        {
            { "MaxItemPrice", _itemPrice }
        };
    }
}
```