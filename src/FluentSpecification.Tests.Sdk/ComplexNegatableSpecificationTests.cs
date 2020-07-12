using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class ComplexNegatableSpecificationTests<T> : ComplexSpecificationTests<T>
        where T : ComplexNegatableSpecificationTests<T>
    {
        protected virtual IComplexNegatableSpecification<TCandidate> CreateNegatableSpecification<TCandidate>(
            NegatableSpecificationFactory<TCandidate> factory)
        {
            return factory.CreateNegation();
        }
    }
}
