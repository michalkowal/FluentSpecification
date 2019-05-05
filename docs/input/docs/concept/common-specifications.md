Description: Description of <a href="/FluentSpecification/api/FluentSpecification/"><code>FluentSpecification</code></a> library content. Common <i>Specifications</i> and <i>Fluent API</i> construction.
Order: 500
---

[`FluentSpecification`](/FluentSpecification/api/FluentSpecification/) package contains common implementation of small reusable Specifications.  
All *Specifications* are based on *Specification design pattern*.  
Every built-in *Specification* implements `IComplexSpecification<T>` interface - support validation scenarios and also can be used like *Linq* expressions, because they are designed and implemented especially for *Entity Framework Core* support and partially for *Entity Framework 6* and tested with these frameworks.  
Library also contains *Fluent API* as a set of methods and extensions for each built-in *Specification*.  

[List of available built-in *Specifications*](/FluentSpecification/built-in/common/).