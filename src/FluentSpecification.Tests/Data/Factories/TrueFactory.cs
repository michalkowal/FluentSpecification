using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class TrueFactory : SpecificationFactory<bool, TrueSpecification>
    {
        public override Expression CastToAbstractExpression(TrueSpecification specification)
            => (Expression)specification;

        public override Expression<Func<bool, bool>> CastToExpression(TrueSpecification specification)
            => specification;

        public override Func<bool, bool> CastToFunc(TrueSpecification specification)
            => specification;

        public override TrueSpecification CreateSpecification()
        {
            return new TrueSpecification();
        }
    }
}
