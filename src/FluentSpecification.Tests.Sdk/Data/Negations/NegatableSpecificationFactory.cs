using FluentSpecification.Abstractions.Generic;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Sdk.Data.Negations
{
    public abstract class NegatableSpecificationFactory<TCandidate> : SpecificationFactory<TCandidate>
    {
        public abstract IComplexNegatableSpecification<TCandidate> CreateNegation();
    }

    public abstract class NegatableSpecificationFactory<TCandidate, TSpecification> : NegatableSpecificationFactory<TCandidate>,
        IComplexSpecificationFactory<TCandidate, TSpecification>
        where TSpecification : class, IComplexSpecification<TCandidate>, IComplexNegatableSpecification<TCandidate>
    {
        public abstract TSpecification CreateSpecification();

        public abstract Expression<Func<TCandidate, bool>> CastToExpression(TSpecification specification);
        public abstract Expression CastToAbstractExpression(TSpecification specification);
        public abstract Func<TCandidate, bool> CastToFunc(TSpecification specification);

        public override IComplexSpecification<TCandidate> Create()
        {
            return CreateSpecification();
        }

        public override IComplexNegatableSpecification<TCandidate> CreateNegation()
        {
            return CreateSpecification();
        }
    }
}
