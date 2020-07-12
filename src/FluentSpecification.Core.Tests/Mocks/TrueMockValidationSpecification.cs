using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class TrueMockValidationSpecification<T> : MockValidationSpecification<T>
    {
        public TrueMockValidationSpecification() : base(true)
        {
            TraceMessage = new SpecificationTrace($"TrueMockValidationSpecification[{typeof(T).Name}]",
                "TrueMockValidation");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}