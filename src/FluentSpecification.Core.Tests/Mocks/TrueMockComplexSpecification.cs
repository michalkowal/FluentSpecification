using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockComplexSpecification<T> : MockComplexSpecification<T>
    {
        public TrueMockComplexSpecification() : base(true)
        {
            TraceMessage = new SpecificationTrace($"TrueMockComplexSpecification[{typeof(T).Name}]",
                "TrueMockComplex");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}