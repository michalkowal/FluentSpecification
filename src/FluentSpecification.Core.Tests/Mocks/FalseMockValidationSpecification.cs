using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class FalseMockValidationSpecification<T> : MockValidationSpecification<T>
    {
        public FalseMockValidationSpecification() : base(false)
        {
            TraceMessage = new SpecificationTrace($"FalseMockValidationSpecification[{typeof(T).Name}]",
                "FalseMockValidation");
        }

        protected override SpecificationTrace TraceMessage { get; }
    }
}