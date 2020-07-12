using System;
using System.Linq.Expressions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Data.Negations;

namespace FluentSpecification.Tests.Data.Factories
{
    public class IsTypeFactory<T> : NegatableSpecificationFactory<T, IsTypeSpecification<T>>
    {
        public Type Expected
        {
            get => Get<Type>(nameof(Expected));
            private set => Set(nameof(Expected), value);
        }

        public IsTypeFactory(Type expected)
        {
            Expected = expected;
        }

        public override IsTypeSpecification<T> CreateSpecification()
        {
            return new IsTypeSpecification<T>(Expected);
        }

        public override Expression<Func<T, bool>> CastToExpression(IsTypeSpecification<T> specification)
            => specification;

        public override Expression CastToAbstractExpression(IsTypeSpecification<T> specification)
            => (Expression)specification;

        public override Func<T, bool> CastToFunc(IsTypeSpecification<T> specification)
            => specification;
    }

    public class IsTypeFactory : DefaultFactoryProxy<object, IsTypeSpecification<object>>
    {
        public IsTypeFactory()
            : base(new IsTypeFactory<object>(typeof(string)))
        {
        }
    }
}
