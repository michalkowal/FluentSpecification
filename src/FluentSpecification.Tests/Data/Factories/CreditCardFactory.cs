using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Negations;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class CreditCardFactory : NegatableSpecificationFactory<string, CreditCardSpecification>
    {
        public override Expression CastToAbstractExpression(CreditCardSpecification specification)
            => (Expression)specification;

        public override Expression<Func<string, bool>> CastToExpression(CreditCardSpecification specification)
            => specification;

        public override Func<string, bool> CastToFunc(CreditCardSpecification specification)
            => specification;

        public override CreditCardSpecification CreateSpecification()
        {
            return new CreditCardSpecification();
        }
    }
}
