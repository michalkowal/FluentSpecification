using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public FalseMockComplexSpecification() : base(false)
        {
            TraceMessage = new SpecificationTrace($"FalseMockComplexSpecification[{typeof(T).Name}]",
                "FalseMockComplex");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}