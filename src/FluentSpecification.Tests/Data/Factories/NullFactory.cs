using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class NullFactory<T> : NegatableSpecificationFactory<T, NullSpecification<T>>
    {
        public override Expression CastToAbstractExpression(NullSpecification<T> specification)
            => (Expression)specification;

        public override Expression<Func<T, bool>> CastToExpression(NullSpecification<T> specification)
            => specification;

        public override Func<T, bool> CastToFunc(NullSpecification<T> specification)
            => specification;

        public override NullSpecification<T> CreateSpecification()
        {
            return new NullSpecification<T>();
        }
    }

    public class NullFactory : DefaultFactoryProxy<string, NullSpecification<string>>
    {
        public NullFactory()
            : base(new NullFactory<string>())
        {
        }
    }
}
