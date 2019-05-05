Description: Description of <a href="/FluentSpecification/api/FluentSpecification.Core/"><code>FluentSpecification.Core</code></a> library content. Core <i>Specifications</i>, abstract types and "utils".
Order: 400
---

[`FluentSpecification.Core`](/FluentSpecification/api/FluentSpecification.Core/) contains first of all, remained implementation of *Specification design pattern*.  
Here you can find *Specifications* for composition (*And*, *Or*) and special extensions for *Fluent API*. Library also contains *Specification* for negation, 
with special validation handling (error message negation) and negation of *Linq expressions*.  
Most of *Specifications* use *abstract* implementation of *validation* and *Linq* *Specifications*, placed in *Core* package.  
At the end package has bunch of utils and extensions, useful in validation scenarios and in *Linq expressions* composing.  

[List of available built-in *Specifications*](/FluentSpecification/built-in/core/).

# Everything is Complex

[As described in previous section](/FluentSpecification/docs/concept/abstraction/) there is `IComplexSpecification<T>` interface, 
aggregation of `ISpecification<T>`, `IValidationSpecification<T>` and `ILinqSpecification<T>` interfaces. Every built-in *Specification* implements `IComplexSpecification<T>` interface.
*And*, *Or*, and *Not* *Specifications* are also "complex", but as input they take "normal" `ISpecification<T>`. Inside, input *Specification* is converted by special extension method - [`AsComplexSpecification`](/FluentSpecification/api/FluentSpecification.Core/Specification/479F235B).  
All *Specifications*, that do not implement `IComplexSpecification<T>` interface, are adapted by internal `SpecificationAdapter<T>`. 
This *Adapter* implements `IComplexSpecification<T>` interface and invokes proper methods from *Base Specification*. 
For example if *Base Specification* not implement *Linq* interface, *Adapter* invokes [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D) method in *Lambda expression*. 
If *Base Specification* has [`GetExpression`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ILinqSpecification_1/24066042), *Adapter* gets this expression from base.  
Other methods are processed similarly (also from [*Negatable*](/FluentSpecification/docs/concept/abstraction#negatable) interfaces).  
`SpecificationAdapter<T>` is internal class, but [`AsComplexSpecification`](/FluentSpecification/api/FluentSpecification.Core/Specification/479F235B) is public extension for every *Specification*.  

**BE AWARE!** *Linq expressions* produced in this way, will not work with *LinqToEntities* (`Ef 6` scenarios). In `EF Core` should works fine.  
For `EF 6`, `ILinqSpecification<T>` implementation with special *expressions* building is necessary.