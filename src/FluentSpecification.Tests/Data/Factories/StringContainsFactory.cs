using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Negations;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class StringContainsFactory : NegatableSpecificationFactory<string, ContainsSpecification>
    {
        public string Expected
        {
            get => Get<string>(nameof(Expected)); 
            private set => Set(nameof(Expected), value);
        }

        public StringContainsFactory()
            : this("lorem ipsum")
        {
        }

        public StringContainsFactory(string expected)
        {
            Expected = expected;
        }

        public override ContainsSpecification CreateSpecification()
        {
            return new ContainsSpecification(Expected);
        }

        public override Expression<Func<string, bool>> CastToExpression(ContainsSpecification specification)
            => specification;

        public override Expression CastToAbstractExpression(ContainsSpecification specification)
            => (Expression)specification;

        public override Func<string, bool> CastToFunc(ContainsSpecification specification)
            => specification;
    }
}
