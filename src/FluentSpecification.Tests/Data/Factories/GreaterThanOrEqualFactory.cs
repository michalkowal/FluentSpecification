using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class GreaterThanOrEqualFactory<T> : NegatableSpecificationFactory<T, GreaterThanOrEqualSpecification<T>>
    {
        public T GreaterThan
        {
            get => Get<T>(nameof(GreaterThan));
            private set => Set(nameof(GreaterThan), value);
        }
        public IComparer<T> Comparer
        {
            get => Get<IComparer<T>>(nameof(Comparer));
            private set => Set(nameof(Comparer), value);
        }

        public GreaterThanOrEqualFactory(T greaterThan, IComparer<T> comparer)
        {
            GreaterThan = greaterThan;
            Comparer = comparer;
        }

        public override GreaterThanOrEqualSpecification<T> CreateSpecification()
        {
            return new GreaterThanOrEqualSpecification<T>(GreaterThan, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(GreaterThanOrEqualSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(GreaterThanOrEqualSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(GreaterThanOrEqualSpecification<T> specification)
            => specification;
    }

    public class GreaterThanOrEqualFactory : DefaultFactoryProxy<string, GreaterThanOrEqualSpecification<string>>
    {
        public GreaterThanOrEqualFactory()
            : base(new GreaterThanOrEqualFactory<string>("", null))
        {
        }
    }
}
