Description: Checks if string is valid credit card number.
Order: 1900
DisplayDescription: true
Support: Full;Full;Full;None
---

Supported card types:
- **Amex**
- BC Global
- Carte Blanche
- Diners Club
- **Discover**
- **Insta Payment**
- JCB
- Korean Local
- Laser
- **Maestro**
- **MasterCard**
- Solo
- Switch
- **UnionPay**
- **Visa**
- **Visa MasterCard**  

The card number can contain **spaces**, **dashes** or be as **one string**.

# Usage

```csharp
var spec = Specification.CreditCard();

spec.IsSatisfiedBy("5500 0000 0000 0004");   // true
spec.IsSatisfiedBy("3400-0000-0000-009");    // true
spec.IsSatisfiedBy("6759649826438453");    // true
spec.IsSatisfiedBy("123456789");    // false
spec.IsSatisfiedBy(null);    // false
```

## As property

```csharp
var customerSpec = Specification.CreditCard<Customer>(c => c.CreditCard.CardNumber);

customerSpec.IsSatisfiedBy(new Customer
{
    CreditCard = new CreditCard { CardNumber = "5500 0000 0000 0004" }
});   // true
customerSpec.IsSatisfiedBy(new Customer
{
    CreditCard = new CreditCard { CardNumber = "123456789" }
});    // false
customerSpec.IsSatisfiedBy(new Customer
{
    CreditCard = new CreditCard { CardNumber = null }
});    // false
```

# Not Credit Card

```csharp
var spec = Specification.NotCreditCard();

spec.IsSatisfiedBy("5500 0000 0000 0004");   // false
spec.IsSatisfiedBy("3400-0000-0000-009");    // false
spec.IsSatisfiedBy("6759649826438453");    // false
spec.IsSatisfiedBy("123456789");    // true
spec.IsSatisfiedBy(null);    // true
```

## As property

```csharp
var customerSpec = Specification.NotCreditCard<Customer>(c => c.CreditCard.CardNumber);

customerSpec.IsSatisfiedBy(new Customer
{
    CreditCard = new CreditCard { CardNumber = "5500 0000 0000 0004" }
});   // false
customerSpec.IsSatisfiedBy(new Customer
{
    CreditCard = new CreditCard { CardNumber = "123456789" }
});    // true
customerSpec.IsSatisfiedBy(new Customer
{
    CreditCard = new CreditCard { CardNumber = null }
});    // true
```

# EF 6 support

Right now `CreditCardSpecification` uses `Regex` for verification - it is not supported in *LinqToEntities* (*LinqToSql*).