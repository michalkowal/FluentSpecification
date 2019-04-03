using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal abstract class MockComplexSpecification<T> :
        MockValidationSpecification<T>, IComplexSpecification<T>
    {
        protected MockComplexSpecification(bool result) : base(result)
        {
        }

        public Expression<Func<T, bool>> GetExpression()
        {
            return obj => IsSatisfiedBy(obj);
        }

        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        public new static IComplexSpecification<T> Create(bool result)
        {
            return result ? True() : False();
        }

        public new static IComplexSpecification<T> True()
        {
            return new TrueMockComplexSpecification<T>();
        }

        public new static IComplexSpecification<T> False()
        {
            return new FalseMockComplexSpecification<T>();
        }
    }

    internal abstract class MockComplexSpecification :
        MockComplexSpecification<object>
    {
        protected MockComplexSpecification(bool result) : base(result)
        {
        }

        public new static IComplexSpecification<object> Create(bool result)
        {
            return result ? True() : False();
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
        public TrueMockComplexSpecification() : base(true)
        {
        }

        protected override string TraceMessage { get; } = "TrueMockComplexSpecification";
    }

    internal class FalseMockComplexSpecification : MockComplexSpecification
    {
        public FalseMockComplexSpecification() : base(false)
        {
        }

        protected override string TraceMessage { get; } = "FalseMockComplexSpecification";
    }
}