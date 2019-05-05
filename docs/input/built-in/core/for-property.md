Description: Verifies if <i>Specification</i> is satisfied by candidate property value.
Order: 400
DisplayDescription: true
Support: Partial;Full;Full;Full
ValidationError: <i>"Field '{PropertyName}' value is not valid"</i>.;Also <i>Specification</i> adds prefix <i>"Field '{PropertyName}':"</i> for each error returned from property value <i>Specification</i>.
ValidationParameters: PropertySelector:Selector passed in constructor.;PropertyName:Name of candidate property.;PropertySpecification:<i>Specification</i> object passed in constructor.
---

# Usage

```csharp
var spec = Specification
    .ForProperty<Customer, CreditCard>(c => c.CreditCard, 
        Specification.NotNull<CreditCard>());

spec.IsSatisfiedBy(
    new Customer {CreditCard = new CreditCard()});  // true
spec.IsSatisfiedBy(
    new Customer {CreditCard = null});  // false


// With sub property
var emailSpec = Specification
    .ForProperty<Customer, string>(c => c.Caretaker.Email,
        Specification.Email());

spec.IsSatisfiedBy(
    new Customer
    {
        Caretaker = new Customer
        {
            Email = "john.doe@email.com"
        }
    });  // true
```

## Extensions

Every built-in *Specification* has extension with `PropertySpecification<T, TProperty>`.

```csharp
Specification
    .ForProperty<Customer, int>(c => c.CustomerId,
        Specification.GreaterThan(0));

// ... is equivalent with:
Specification.GreaterThan<Customer, int>(
    c => c.CustomerId, 0);
```

## Null support

`PropertySpecification<T, TProperty>` doesn't throw `NullReferenceException`, when candidate or his sub-property is `null`, but returns `false`.  
`Null` as value of property works normally.

```csharp
var spec = Specification
    .CreditCard<Customer>(c => c.CreditCard.CardNumber);

spec.IsSatisfiedBy(new Customer {CreditCard = new CreditCard {CardNumber = null}}); // return false, because Specification result
spec.IsSatisfiedBy(new Customer {CreditCard = null});   // return false
spec.IsSatisfiedBy(null);   // return false
```