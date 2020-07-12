using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class ContainsFactory<T, TType> : NegatableSpecificationFactory<T, ContainsSpecification<T, TType>>
        where T : IEnumerable<TType>
    {
        public TType Expected
        {
            get => Get<TType>(nameof(Expected));
            private set => Set(nameof(Expected), value);
        }
        public IEqualityComparer<TType> Comparer
        {
            get => Get<IEqualityComparer<TType>>(nameof(Comparer));
            private set => Set(nameof(Comparer), value);
        }

        public ContainsFactory(TType expected, IEqualityComparer<TType> comparer)
        {
            Expected = expected;
            Comparer = comparer;
        }

        public override ContainsSpecification<T, TType> CreateSpecification()
        {
            return new ContainsSpecification<T, TType>(Expected, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(ContainsSpecification<T, TType> specification)
            => specification;

        public override Expression CastToAbstractExpression(ContainsSpecification<T, TType> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(ContainsSpecification<T, TType> specification)
            => specification;
    }

    public class ContainsFactory : DefaultFactoryProxy<string[], ContainsSpecification<string[], string>>
    {
        public ContainsFactory() 
            : base(new ContainsFactory<string[], string>("", null))
        {
        }
    }
}
