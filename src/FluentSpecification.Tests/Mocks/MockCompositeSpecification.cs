using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core;

namespace FluentSpecification.Tests.Mocks
{
    internal class MockCompositeSpecification<T> : ICompositeSpecification<T>
    {
        public ISpecification<T> BaseSpecification { get; } = MockComplexSpecification<T>.True();

        public IComplexSpecification<T> Compose(ISpecification<T> other)
        {
            return other.AsComplexSpecification();
        }
    }
}