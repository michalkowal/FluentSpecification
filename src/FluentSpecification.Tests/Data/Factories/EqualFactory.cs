using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class EqualFactory<T> : NegatableSpecificationFactory<T, EqualSpecification<T>>
    {
        public T Expected
        {
            get => Get<T>(nameof(Expected));
            private set => Set(nameof(Expected), value);
        }
        public IEqualityComparer<T> Comparer
        {
            get => Get<IEqualityComparer<T>>(nameof(Comparer));
            private set => Set(nameof(Comparer), value);
        }

        public EqualFactory(T expected, IEqualityComparer<T> comparer)
        {
            Expected = expected;
            Comparer = comparer;
        }

        public override EqualSpecification<T> CreateSpecification()
        {
            return new EqualSpecification<T>(Expected, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(EqualSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(EqualSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(EqualSpecification<T> specification)
            => specification;
    }

    public class EqualFactory : DefaultFactoryProxy<string, EqualSpecification<string>>
    {
        public EqualFactory() 
            : base(new EqualFactory<string>("", null))
        {
        }
    }
}
