using System;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal sealed class MockLinqSpecification<T> :
        ILinqSpecification<T>,
        INegatableLinqSpecification<T>
    {
        private readonly Expression<Func<T, bool>> _expression;
        private readonly Expression<Func<T, bool>> _negation;

        public MockLinqSpecification(Expression<Func<T, bool>> expression, Expression<Func<T, bool>> negation = null)
        {
            _expression = expression;
            _negation = negation;
        }

        public Expression<Func<T, bool>> GetExpression()
        {
            return _expression;
        }

        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return GetExpression().Compile().Invoke(candidate);
        }

        public Expression<Func<T, bool>> GetNegationExpression()
        {
            return _negation;
        }

        public bool IsNotSatisfiedBy(T candidate)
        {
            return GetNegationExpression().Compile().Invoke(candidate);
        }
    }
}