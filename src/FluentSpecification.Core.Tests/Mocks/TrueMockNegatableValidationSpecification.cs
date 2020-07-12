using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockNegatableValidationSpecification<T> : MockNegatableValidationSpecification<T>
    {
        public TrueMockNegatableValidationSpecification() : base(true)
        {
            TraceMessage = new SpecificationTrace($"TrueMockNegatableValidationSpecification[{typeof(T).Name}]",
                "TrueMockNegatableValidation");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}