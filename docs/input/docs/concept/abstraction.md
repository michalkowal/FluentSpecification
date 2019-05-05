Description: Description of <a href="/FluentSpecification/api/FluentSpecification.Abstractions/"><code>FluentSpecification.Abstractions</code></a> library content (interfaces) and differences between classic <i>Specification</i> pattern.
Order: 200
---

[`FluentSpecification.Abstractions`](/FluentSpecification/api/FluentSpecification.Abstractions/) is a abstraction layer for **Specification design pattern**. Contains also interfaces and structures for validation and *Linq* scenarios.

<div class="mermaid abstraction">
	graph BT;
		ISpecificationGeneric["ISpecification#lt;T#gt;"] --> ISpecification;
		IValidationSpecificationGeneric["IValidationSpecification#lt;T#gt;"] --> ISpecificationGeneric;
		ILinqSpecificationGeneric["ILinqSpecification#lt;T#gt;"] --> ILinqSpecification;
		ILinqSpecificationGeneric --> ISpecificationGeneric;
		IComplexSpecification["IComplexSpecification#lt;T#gt;"] --> ISpecificationGeneric;
		IComplexSpecification --> IValidationSpecificationGeneric;
		IComplexSpecification --> ILinqSpecificationGeneric;
</div>

# Specification

`ISpecification<T>` is absolutely base, for all *Specifications* and extensions, across all *FluentSpecification* packages. 
But there is couple of differences with known *Specification design pattern* - interface contains only [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D) method without *And*, *Or* etc. 
This methods are moved as extensions to the [`FluentSpecification.Core`](/FluentSpecification/api/FluentSpecification.Core/). 
Thanks that implementation of simple *Specification* is very easy - you need to implement only [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D) method.  
Every *Specifications* also implements empty `ISpecification` interface - you can represent any kind of *Specification* regardless of the type.

# Validation

For *Validation* scenarios, `IValidationSpecification<T>` is prepared. This interface inherit from `ISpecification<T>`.  
Contains also [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/IValidationSpecification_1/DCBDBED1) method but with outer parameter - `SpecificationResult`. 
In this structure, *Specification* returns all data related to validation of input candidate. Content of `SpecificationResult` is described in [next section](/FluentSpecification/docs/concept/validation-result).

# Linq

*Specifications*, that support *Linq expressions*, should implement `ILinqSpecification<T>` interface. 
[`GetExpression`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ILinqSpecification_1/24066042) method returns equivalent of [`IsSatisfiedBy`](/FluentSpecification/api/FluentSpecification.Abstractions.Generic/ISpecification_1/D6A7440D) method, as *Linq expression*. 
`ILinqSpecification<T>` inherit from `ISpecification<T>`.

# All in one

`IComplexSpecification<T>` interface, is prepared for *Specifications* with support of all functionalities, described above. Every built-in *Specifications* implements this interface.

# Negatable

<div class="mermaid">
	graph BT;
		INegatableSpecificationGeneric["INegatableSpecification#lt;T#gt;"] --> ISpecification;
		INegatableValidationSpecificationGeneric["INegatableValidationSpecification#lt;T#gt;"] --> INegatableSpecificationGeneric;
		INegatableLinqSpecificationGeneric["INegatableLinqSpecification#lt;T#gt;"] --> INegatableSpecificationGeneric;
</div>