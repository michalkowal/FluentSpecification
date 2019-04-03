using System.Collections.Generic;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockValidationSpecification<T> :
        MockSpecification<T>, IValidationSpecification<T>
    {
        protected MockValidationSpecification(bool result) : base(result)
        {
        }

        protected abstract string TraceMessage { get; }

        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var overall = IsSatisfiedBy(candidate);
            var trace = TraceMessage;

            if (!overall)
            {
                var error = new FailedSpecification(GetType(), GetParameters(), candidate,
                    "MockValidationSpecification is not satisfied");
                trace = "Failed" + trace;
                result = new SpecificationResult(false, trace, error);
            }
            else
            {
                result = new SpecificationResult(true, trace);
            }


            return overall;
        }

        protected IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Result", Result}
            };
        }

        public new static IValidationSpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IValidationSpecification<T> True()
        {
            return new TrueMockValidationSpecification<T>();
        }

        public new static IValidationSpecification<T> False()
        {
            return new FalseMockValidationSpecification<T>();
        }
    }

    internal abstract class MockValidationSpecification :
        MockValidationSpecification<object>
    {
        protected MockValidationSpecification(bool result) : base(result)
        {
        }

        public new static IValidationSpecification<object> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IValidationSpecification<object> True()
        {
            return new TrueMockValidationSpecification();
        }

        public new static IValidationSpecification<object> False()
        {
            return new FalseMockValidationSpecification();
        }
    }

    internal class TrueMockValidationSpecification : MockValidationSpecification
    {
        public TrueMockValidationSpecification() : base(true)
        {
        }

        protected override string TraceMessage { get; } = "TrueMockValidationSpecification";
    }

    internal class FalseMockValidationSpecification : MockValidationSpecification
    {
        public FalseMockValidationSpecification() : base(false)
        {
        }

        protected override string TraceMessage { get; } = "FalseMockValidationSpecification";
    }
}