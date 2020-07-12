using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockNegatableComplexSpecification<T> : MockNegatableComplexSpecification<T>
    {
        public FalseMockNegatableComplexSpecification() : base(false)
        {
            TraceMessage = new SpecificationTrace($"FalseMockNegatableComplexSpecification[{typeof(T).Name}]",
                "FalseMockNegatableComplex");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}