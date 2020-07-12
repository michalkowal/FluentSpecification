using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class LessThanFactory<T> : NegatableSpecificationFactory<T, LessThanSpecification<T>>
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

        public LessThanFactory(T lessThan, IComparer<T> comparer)
        {
            LessThan = lessThan;
            Comparer = comparer;
        }

        public override LessThanSpecification<T> CreateSpecification()
        {
            return new LessThanSpecification<T>(LessThan, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(LessThanSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(LessThanSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(LessThanSpecification<T> specification)
            => specification;
    }

    public class LessThanFactory : DefaultFactoryProxy<string, LessThanSpecification<string>>
    {
        public LessThanFactory()
            : base(new LessThanFactory<string>("", null))
        {
        }
    }
}
