using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class MockCommonSpecification<T> : 
        ComplexSpecification<T>,
        IFailableSpecification<T>,
        IFailableNegatableSpecification<T>
    {
        public string GetFailedMessage(T candidate)
        {
            return "Not match";
        }

        public string GetFailedNegationMessage(T candidate)
        {
            return "Match";
        }

        protected override Expression BuildValueTypeExpressionBody(Expression parameter)
        {
            return Expression.Constant(true);
        }

        protected override Expression BuildExpressionBody(Expression parameter)
        {
            return Expression.Constant(false);
        }
    }
}