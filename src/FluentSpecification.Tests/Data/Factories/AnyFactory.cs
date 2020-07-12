using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data.Factories
{
    public class AnyFactory<T, TType> : SpecificationFactory<T, AnySpecification<T, TType>>
        where T : IEnumerable<TType>
    {
        public Expression<Func<TType, bool>> Expression
        {
            get => Get<Expression<Func<TType, bool>>>(nameof(Expression));
            private set => Set(nameof(Expression), value);
        }

        public ISpecification<TType> SpecificationForAny
        {
            get => Get<ISpecification<TType>>(nameof(SpecificationForAny));
            private set => Set(nameof(SpecificationForAny), value);
        }

        public AnyFactory(Expression<Func<TType, bool>> expression)
        {
            Expression = expression;
            SpecificationForAny = new MockComplexSpecification<TType>(Expression);
        }

        public override AnySpecification<T, TType> CreateSpecification()
        {
            return new AnySpecification<T, TType>(SpecificationForAny);
        }

        public override Expression<Func<T, bool>> CastToExpression(AnySpecification<T, TType> specification)
            => specification;

        public override Expression CastToAbstractExpression(AnySpecification<T, TType> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(AnySpecification<T, TType> specification)
            => specification;
    }

    public class AnyFactory : DefaultFactoryProxy<string[], AnySpecification<string[], string>>
    {
        public AnyFactory() 
            : base(new AnyFactory<string[], string>(candidate => true))
        {
        }
    }
}
