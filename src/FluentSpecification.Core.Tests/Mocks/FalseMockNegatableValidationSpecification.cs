using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockNegatableValidationSpecification<T> : MockNegatableValidationSpecification<T>
    {
        public FalseMockNegatableValidationSpecification() : base(false)
        {
            TraceMessage = new SpecificationTrace($"FalseMockNegatableValidationSpecification[{typeof(T).Name}]",
                "FalseMockNegatableValidation");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}