using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockNegatableComplexSpecification<T> : MockNegatableComplexSpecification<T>
    {
        public TrueMockNegatableComplexSpecification() : base(true)
        {
            TraceMessage = new SpecificationTrace($"TrueMockNegatableComplexSpecification[{typeof(T).Name}]",
                "TrueMockNegatableComplex");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}