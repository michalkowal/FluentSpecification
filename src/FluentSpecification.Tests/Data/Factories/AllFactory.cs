using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data.Factories
{
    public class AllFactory<T, TType> : SpecificationFactory<T, AllSpecification<T, TType>>
        where T : IEnumerable<TType>
    {
        public Expression<Func<TType, bool>> Expression
        {
            get => Get<Expression<Func<TType, bool>>>(nameof(Expression));
            private set => Set(nameof(Expression), value);
        }

        public ISpecification<TType> SpecificationForAll
        {
            get => Get<ISpecification<TType>>(nameof(SpecificationForAll));
            private set => Set(nameof(SpecificationForAll), value);
        }

        public AllFactory(Expression<Func<TType, bool>> expression)
        {
            Expression = expression;
            SpecificationForAll = new MockComplexSpecification<TType>(Expression);
        }

        public override AllSpecification<T, TType> CreateSpecification()
        {
            return new AllSpecification<T, TType>(SpecificationForAll);
        }

        public override Expression<Func<T, bool>> CastToExpression(AllSpecification<T, TType> specification)
            => specification;

        public override Expression CastToAbstractExpression(AllSpecification<T, TType> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(AllSpecification<T, TType> specification)
            => specification;
    }

    public class AllFactory : DefaultFactoryProxy<string[], AllSpecification<string[], string>>
    {
        public AllFactory() 
            : base(new AllFactory<string[], string>(candidate => true))
        {
        }
    }
}
