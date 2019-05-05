Description: Custom, normall <i>Specification</i> implementation.
Order: 100
---

To create custom *Specification* type, just need to implement `ISpecification<T>` interface from [`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) package.

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
```

Type, prepared in this way can be used with other, built-in *Specifications*.

```csharp
var customerSpec = Specification
    .NotNull<Customer>()
    // Create 'VipCustomerSpecification' by parameterless constructor
    .And<Customer, VipCustomerSpecification>();
```