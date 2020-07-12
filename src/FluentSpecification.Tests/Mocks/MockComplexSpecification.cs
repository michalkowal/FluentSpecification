using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Utils;

namespace FluentSpecification.Tests.Mocks
{
    internal class MockComplexSpecification<T> :
        IComplexSpecification<T>
    {
        private readonly Expression<Func<T, bool>> _expression;

        public MockComplexSpecification(Expression<Func<T, bool>> expression)
        {
            _expression = expression;
            TraceMessage = $"MockComplexSpecification[{typeof(T).GetShortName()}]";
            ShortTraceMessage = "MockComplex";
        }

        protected string TraceMessage { get; set; }
        protected string ShortTraceMessage { get; set; }

        public bool IsSatisfiedBy(T candidate)
        {
            return _expression.Compile().Invoke(candidate);
        }

        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var overall = IsSatisfiedBy(candidate);

            var traceMessage = TraceMessage;
            var shortTraceMessage = ShortTraceMessage;
            if (!overall)
            {
                traceMessage = "Failed" + traceMessage;
                shortTraceMessage = "Failed" + shortTraceMessage;
            }

            var info = new SpecificationInfo(overall, GetType(), false, GetParameters(), candidate,
                        overall ? null : new [] { "MockComplexSpecification is not satisfied" });
            var trace = new SpecificationTrace(traceMessage, shortTraceMessage);
            
            result = new SpecificationResult(overall, trace, info);

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
            ShortTraceMessage = "TrueMockComplex";
        }
    }

    internal class FalseMockComplexSpecification : MockComplexSpecification
    {
        public FalseMockComplexSpecification() : base(candidate => false)
        {
            TraceMessage = "FalseMockComplexSpecification";
            ShortTraceMessage = "FalseMockComplex";
        }
    }
}