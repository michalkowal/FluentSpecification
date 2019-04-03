using System.Linq.Expressions;

namespace FluentSpecification.Core.Tests.Mocks
{
    internal class MockCommonSpecification<T> : ComplexSpecification<T>
    {
        protected override string CreateFailedMessage(T candidate)
        {
            return "Not match";
        }

        protected override string CreateNegationFailedMessage(T candidate)
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