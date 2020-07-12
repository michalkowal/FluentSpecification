using FluentSpecification.Abstractions.Generic;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Sdk.Data
{
    public abstract class DefaultFactoryProxy<TCandidate, TSpecification> : SpecificationFactory<TCandidate, TSpecification>
        where TSpecification : class, IComplexSpecification<TCandidate>
    {
        private readonly IComplexSpecificationFactory<TCandidate, TSpecification> _baseFactory;

        public DefaultFactoryProxy(IComplexSpecificationFactory<TCandidate, TSpecification> baseFactory)
        {
            _baseFactory = baseFactory;
        }

        public override Expression CastToAbstractExpression(TSpecification specification)
        {
            return _baseFactory.CastToAbstractExpression(specification);
        }

        public override Expression<Func<TCandidate, bool>> CastToExpression(TSpecification specification)
        {
            return _baseFactory.CastToExpression(specification);
        }

        public override Func<TCandidate, bool> CastToFunc(TSpecification specification)
        {
            return _baseFactory.CastToFunc(specification);
        }

        public override TSpecification CreateSpecification()
        {
            return _baseFactory.CreateSpecification();
        }
    }
}
