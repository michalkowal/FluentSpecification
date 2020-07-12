using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockNegatableValidationSpecification<T> :
        MockValidationSpecification<T>,
        INegatableValidationSpecification<T>
    {
        protected MockNegatableValidationSpecification(bool result) : base(result)
        {
        }

        public bool IsNotSatisfiedBy(T candidate)
        {
            return !Result;
        }

        public bool IsNotSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var overall = IsNotSatisfiedBy(candidate);
            var trace = new SpecificationTrace("Not" + TraceMessage.FullTrace, "Not" + TraceMessage.ShortTrace);
            string[] error = null;

            if (!overall)
            {
                error = new[] 
                {
                    "NotMockNegatableValidationSpecification is satisfied"
                };
                trace = new SpecificationTrace("Failed" + trace.FullTrace, "Failed" + trace.ShortTrace);
            }

            result = new SpecificationResult(overall, trace, new SpecificationInfo(
                overall, GetType(), true, GetParameters(), candidate, error));

            return overall;
        }

        public new static IValidationSpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IValidationSpecification<T> True()
        {
            return new TrueMockNegatableValidationSpecification<T>();
        }

        public new static IValidationSpecification<T> False()
        {
            return new FalseMockNegatableValidationSpecification<T>();
        }
    }

    internal abstract class MockNegatableValidationSpecification :
        MockNegatableValidationSpecification<object>
    {
        protected MockNegatableValidationSpecification(bool result) : base(result)
        {
        }

        public new static IValidationSpecification<object> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IValidationSpecification<object> True()
        {
            return new TrueMockNegatableValidationSpecification();
        }

        public new static IValidationSpecification<object> False()
        {
            return new FalseMockNegatableValidationSpecification();
        }
    }

    internal class TrueMockNegatableValidationSpecification : MockNegatableValidationSpecification
    {
        public TrueMockNegatableValidationSpecification() : base(true)
        {
        }

        protected override SpecificationTrace TraceMessage { get; } = 
            new SpecificationTrace("TrueMockNegatableValidationSpecification",
                "TrueMockNegatableValidation");
    }

    internal class FalseMockNegatableValidationSpecification : MockNegatableValidationSpecification
    {
        public FalseMockNegatableValidationSpecification() : base(false)
        {
        }

        protected override SpecificationTrace TraceMessage { get; } = 
            new SpecificationTrace("FalseMockNegatableValidationSpecification",
                "FalseMockNegatableValidation");
    }
}