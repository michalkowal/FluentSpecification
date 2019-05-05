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
            var trace = "Not" + TraceMessage;

            if (!overall)
            {
                var error = new FailedSpecification(GetType(), GetParameters(), candidate,
                    "NotMockNegatableValidationSpecification is satisfied");
                trace = "Failed" + trace;
                result = new SpecificationResult(false, trace, error);
            }
            else
            {
                result = new SpecificationResult(true, trace);
            }


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

        protected override string TraceMessage { get; } = "TrueMockNegatableValidationSpecification";
    }

    internal class FalseMockNegatableValidationSpecification : MockNegatableValidationSpecification
    {
        public FalseMockNegatableValidationSpecification() : base(false)
        {
        }

        protected override string TraceMessage { get; } = "FalseMockNegatableValidationSpecification";
    }
}