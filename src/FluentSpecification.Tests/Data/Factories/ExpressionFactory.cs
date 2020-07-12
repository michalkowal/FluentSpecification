using System;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data.Factories
{
    public class ExpressionFactory<T> : SpecificationFactory<T, ExpressionSpecification<T>>
    {
        public Expression<Func<T, bool>> Expression
        {
            get => Get<Expression<Func<T, bool>>>(nameof(Expression));
            private set => Set(nameof(Expression), value);
        }

        public ExpressionFactory(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }

        public override ExpressionSpecification<T> CreateSpecification()
        {
            return new ExpressionSpecification<T>(Expression);
        }

        public override Expression<Func<T, bool>> CastToExpression(ExpressionSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(ExpressionSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(ExpressionSpecification<T> specification)
            => specification;
    }

    public class ExpressionFactory : DefaultFactoryProxy<string, ExpressionSpecification<string>>
    {
        public ExpressionFactory()
            : base(new ExpressionFactory<string>(candidate => true))
        {
        }
    }
}
