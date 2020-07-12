using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class ExclusiveBetweenFactory<T> : NegatableSpecificationFactory<T, ExclusiveBetweenSpecification<T>>
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

        public ExclusiveBetweenFactory(T from, T to, IComparer<T> comparer)
        {
            From = from;
            To = to;
            Comparer = comparer;
        }

        public override ExclusiveBetweenSpecification<T> CreateSpecification()
        {
            return new ExclusiveBetweenSpecification<T>(From, To, Comparer);
        }

        public override Expression<Func<T, bool>> CastToExpression(ExclusiveBetweenSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(ExclusiveBetweenSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(ExclusiveBetweenSpecification<T> specification)
            => specification;
    }

    public class ExclusiveBetweenFactory : DefaultFactoryProxy<string, ExclusiveBetweenSpecification<string>>
    {
        public ExclusiveBetweenFactory()
            : base(new ExclusiveBetweenFactory<string>("", "", null))
        {
        }
    }
}
