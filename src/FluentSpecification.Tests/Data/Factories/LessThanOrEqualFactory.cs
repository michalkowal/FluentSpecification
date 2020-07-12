using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class LessThanOrEqualFactory<T> : NegatableSpecificationFactory<T, LessThanOrEqualSpecification<T>>
    {
        public T LessThan
        {
            get => Get<T>(nameof(LessThan));
            private set => Set(nameof(LessThan), value);
        }
        public IComparer<T> Comparer
        {
            get => Get<IComparer<T>>(nameof(Comparer));
            private set => Set(nameof(Comparer), value);
        }

        public LessThanOrEqualFactory(T lessThan, IComparer<T> comparer)
        {
            LessThan = lessThan;
            Comparer = comparer;
        }

        public override LessThanOrEqualSpecification<T> CreateSpecification()
        {
            return new LessThanOrEqualSpecification<T>(LessThan, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(LessThanOrEqualSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(LessThanOrEqualSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(LessThanOrEqualSpecification<T> specification)
            => specification;
    }

    public class LessThanOrEqualFactory : DefaultFactoryProxy<string, LessThanOrEqualSpecification<string>>
    {
        public LessThanOrEqualFactory()
            : base(new LessThanOrEqualFactory<string>("", null))
        {
        }
    }
}
