using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Negations;
using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class EmptyFactory<T> : NegatableSpecificationFactory<T, EmptySpecification<T>>
    {
        public override Expression CastToAbstractExpression(EmptySpecification<T> specification)
            => (Expression)specification;

        public override Expression<Func<T, bool>> CastToExpression(EmptySpecification<T> specification)
            => specification;

        public override Func<T, bool> CastToFunc(EmptySpecification<T> specification)
            => specification;

        public override EmptySpecification<T> CreateSpecification()
        {
            return new EmptySpecification<T>();
        }
    }

    public class EmptyFactory : DefaultFactoryProxy<int, EmptySpecification<int>>
    {
        public EmptyFactory()
            : base(new EmptyFactory<int>())
        {
        }
    }
}
