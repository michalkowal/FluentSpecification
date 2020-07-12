using FluentSpecification.Abstractions.Generic;
using System;
using System.Linq.Expressions;

namespace FluentSpecification.Tests.Sdk.Data
{
    public interface IComplexSpecificationFactory<TCandidate, TSpecification>
        where TSpecification : class, IComplexSpecification<TCandidate>
    {
        TSpecification CreateSpecification();

        Expression<Func<TCandidate, bool>> CastToExpression(TSpecification specification);
        Expression CastToAbstractExpression(TSpecification specification);
        Func<TCandidate, bool> CastToFunc(TSpecification specification);
    }
}
