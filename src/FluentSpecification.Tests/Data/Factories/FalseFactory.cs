using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class FalseFactory : SpecificationFactory<bool, FalseSpecification>
    {
        public override Expression CastToAbstractExpression(FalseSpecification specification)
            => (Expression)specification;

        public override Expression<Func<bool, bool>> CastToExpression(FalseSpecification specification)
            => specification;

        public override Func<bool, bool> CastToFunc(FalseSpecification specification)
            => specification;

        public override FalseSpecification CreateSpecification()
        {
            return new FalseSpecification();
        }
    }
}
