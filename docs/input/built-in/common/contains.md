Description: Checks if candidate contains expected element or string.
Order: 1700
DisplayDescription: true
Support: Full;Full;Full;Partial;Full
---

`ContainsSpecification` occurs in two versions: for **strings** and for **collections**.

# Usage

```csharp
var stringSpec = Specification.Contains("ipsum");

stringSpec.IsSatisfiedBy("Lorem ipsum");    // true
stringSpec.IsSatisfiedBy("dolor sit amet");   // false
stringSpec.IsSatisfiedBy(null); // false


var arraySpec = Specification.Contains<int[], int>(-1);

arraySpec.IsSatisfiedBy(new int[] {2, -1, 5});  // true
arraySpec.IsSatisfiedBy(new int[] {12, 6, 7});  // false
arraySpec.IsSatisfiedBy(null); // false
```

## As property

```csharp
var stringSpec = Specification.Contains<Customer>(
	c => c.Comments, "ipsum");

stringSpec.IsSatisfiedBy(new Customer { Comments = "Lorem ipsum" });    // true
stringSpec.IsSatisfiedBy(new Customer { Comments = "dolor sit amet" });   // false
stringSpec.IsSatisfiedBy(new Customer { Comments = null }); // false


// Use string as collection
var arraySpec = Specification.Contains<Customer, char>(
	c => c.Email, '@');

arraySpec.IsSatisfiedBy(new Customer { Email = "correct@email.com" });  // true
arraySpec.IsSatisfiedBy(new Customer { Email = "incorrect" });  // false
arraySpec.IsSatisfiedBy(new Customer { Email = null }); // false
```

# Not Contains

```csharp
var stringSpec = Specification.NotContains("ipsum");

stringSpec.IsSatisfiedBy("Lorem ipsum");    // false
stringSpec.IsSatisfiedBy("dolor sit amet");   // true
stringSpec.IsSatisfiedBy(null); // true


var arraySpec = Specification.NotContains<int[], int>(-1);

arraySpec.IsSatisfiedBy(new int[] {2, -1, 5});  // false
arraySpec.IsSatisfiedBy(new int[] {12, 6, 7});  // true
arraySpec.IsSatisfiedBy(null); // true
```

## As property

```csharp
var stringSpec = Specification.NotContains<Customer>(
	c => c.Comments, "ipsum");

stringSpec.IsSatisfiedBy(new Customer { Comments = "Lorem ipsum" });    // false
stringSpec.IsSatisfiedBy(new Customer { Comments = "dolor sit amet" });   // true
stringSpec.IsSatisfiedBy(new Customer { Comments = null }); // true


// Use string as collection
var arraySpec = Specification.NotContains<Customer, char>(
	c => c.Email, '@');

arraySpec.IsSatisfiedBy(new Customer { Email = "correct@email.com" });  // false
arraySpec.IsSatisfiedBy(new Customer { Email = "incorrect" });  // true
arraySpec.IsSatisfiedBy(new Customer { Email = null }); // true
```

# Equality Comparer

`ContainsSpecification<T, TType>` supports `IEqualityComparer<TType>`.

```csharp
var spec = Specification.Contains<double[], double>(
    0, EqualityComparer<double>.Default);
```

# EF 6 support

`StringContainsSpecification` works correctly in both *EF* solutions. Problem is with `ContainsSpecification<T, TType>`.  
*LinqToEntities* cannot create const value of non primitive. Instead of *Contains*, [AnySpecification](/FluentSpecification/built-in/common/any) will be better solution.

```csharp
using (var context = new EfDbContext())
{
    var containsSpec = Specification
        .Contains<Customer, Item>(c => c.Items, new Item {ItemId = 1000});
    // var customers = context.Customers.Where(containsSpec.GetExpression()).ToList();   // Exception!

    Specification.LinqToEntities = true;
    var anySpec = Specification
        .Any<Customer, Item>(c => c.Items, 
            Specification.Equal<Item, int>(i => i.ItemId, 1000));
    var customers = context.Customers.Where(anySpec.GetExpression()).ToList();   // Works!
}
```