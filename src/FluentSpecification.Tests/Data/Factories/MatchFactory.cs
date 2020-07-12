using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data.Negations;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Data.Factories
{
    public class MatchFactory : NegatableSpecificationFactory<string, MatchSpecification>
    {
        public string Pattern
        {
            get => Get<string>(nameof(Pattern)); 
            private set => Set(nameof(Pattern), value);
        }

        public MatchFactory()
            : this(".+")
        {
        }

        public MatchFactory(string pattern)
        {
            Pattern = pattern;
        }

        public override MatchSpecification CreateSpecification()
        {
            return new MatchSpecification(Pattern);
        }

        public override Expression<Func<string, bool>> CastToExpression(MatchSpecification specification)
            => specification;

        public override Expression CastToAbstractExpression(MatchSpecification specification)
            => (Expression)specification;

        public override Func<string, bool> CastToFunc(MatchSpecification specification)
            => specification;
    }
}
