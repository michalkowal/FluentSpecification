using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Negations;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class EmailFactory : NegatableSpecificationFactory<string, EmailSpecification>
    {
        public override Expression CastToAbstractExpression(EmailSpecification specification)
            => (Expression)specification;

        public override Expression<Func<string, bool>> CastToExpression(EmailSpecification specification)
            => specification;

        public override Func<string, bool> CastToFunc(EmailSpecification specification)
            => specification;

        public override EmailSpecification CreateSpecification()
        {
            return new EmailSpecification();
        }
    }
}
