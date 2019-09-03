using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;

namespace FluentSpecification.Tests.Mocks
{
    internal class MockComplexSpecification<T> :
        IComplexSpecification<T>
    {
        private readonly Expression<Func<T, bool>> _expression;

        public MockComplexSpecification(Expression<Func<T, bool>> expression)
        {
            _expression = expression;
            TraceMessage = $"MockComplexSpecification[{SpecificationResultGenerator.GetTypeShortName(typeof(T))}]";
        }

        protected string TraceMessage { get; set; }

        public bool IsSatisfiedBy(T candidate)
        {
            return _expression.Compile().Invoke(candidate);
        }

        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var overall = IsSatisfiedBy(candidate);
            var trace = TraceMessage;

            if (!overall)
            {
                var error = new SpecificationInfo(GetType(), GetParameters(), candidate,
                    "MockComplexSpecification is not satisfied");
                trace = "Failed" + trace;
                result = new SpecificationResult(false, trace, error);
            }
            else
            {
                result = new SpecificationResult(true, trace);
            }


            return overall;
        }

        public Expression<Func<T, bool>> GetExpression()
        {
            return _expression;
        }

        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        private IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Expression", _expression}
            };
        }

        public static IComplexSpecification<T> True()
        {
            return new TrueMockComplexSpecification<T>();
        }

        public static IComplexSpecification<T> False()
        {
            return new FalseMockComplexSpecification<T>();
        }
    }

    internal class MockComplexSpecification :
        MockComplexSpecification<object>
    {
        protected MockComplexSpecification(Expression<Func<object, bool>> expression) :
            base(expression)
        {
            TraceMessage = "MockComplexSpecification";
        }

        public new static IComplexSpecification<object> True()
        {
            return new TrueMockComplexSpecification();
        }

        public new static IComplexSpecification<object> False()
        {
            return new FalseMockComplexSpecification();
        }
    }

    internal class TrueMockComplexSpecification : MockComplexSpecification
    {
        public TrueMockComplexSpecification() : base(candidate => true)
        {
            TraceMessage = "TrueMockComplexSpecification";
        }
    }

    internal class FalseMockComplexSpecification : MockComplexSpecification
    {
        public FalseMockComplexSpecification() : base(candidate => false)
        {
            TraceMessage = "FalseMockComplexSpecification";
        }
    }
}