using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class InclusiveBetweenFactory<T> : NegatableSpecificationFactory<T, InclusiveBetweenSpecification<T>>
    {
        public T From
        {
            get => Get<T>(nameof(From));
            private set => Set(nameof(From), value);
        }

        public T To
        {
            get => Get<T>(nameof(To));
            private set => Set(nameof(To), value);
        }

        public IComparer<T> Comparer
        {
            get => Get<IComparer<T>>(nameof(Comparer));
            private set => Set(nameof(Comparer), value);
        }

        public InclusiveBetweenFactory(T from, T to, IComparer<T> comparer)
        {
            From = from;
            To = to;
            Comparer = comparer;
        }

        public override InclusiveBetweenSpecification<T> CreateSpecification()
        {
            return new InclusiveBetweenSpecification<T>(From, To, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(InclusiveBetweenSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(InclusiveBetweenSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(InclusiveBetweenSpecification<T> specification)
            => specification;
    }

    public class InclusiveBetweenFactory : DefaultFactoryProxy<string, InclusiveBetweenSpecification<string>>
    {
        public InclusiveBetweenFactory()
            : base(new InclusiveBetweenFactory<string>("", "", null))
        {
        }
    }
}
