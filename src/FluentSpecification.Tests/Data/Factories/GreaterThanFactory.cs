using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class GreaterThanFactory<T> : NegatableSpecificationFactory<T, GreaterThanSpecification<T>>
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

        public GreaterThanFactory(T greaterThan, IComparer<T> comparer)
        {
            GreaterThan = greaterThan;
            Comparer = comparer;
        }

        public override GreaterThanSpecification<T> CreateSpecification()
        {
            return new GreaterThanSpecification<T>(GreaterThan, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(GreaterThanSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(GreaterThanSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(GreaterThanSpecification<T> specification)
            => specification;
    }

    public class GreaterThanFactory : DefaultFactoryProxy<string, GreaterThanSpecification<string>>
    {
        public GreaterThanFactory()
            : base(new GreaterThanFactory<string>("", null))
        {
        }
    }
}
