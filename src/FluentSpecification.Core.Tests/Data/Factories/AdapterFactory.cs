using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FluentSpecification.Core.Tests.Data.Factories
{
    public class AdapterFactory<T> : SpecificationFactory<T, SpecificationAdapter<T>>
    {
        public override Expression CastToAbstractExpression(SpecificationAdapter<T> specification)
        {
            throw new NotImplementedException();
        }

        public override Expression<Func<T, bool>> CastToExpression(SpecificationAdapter<T> specification)
        {
            throw new NotImplementedException();
        }

        public override Func<T, bool> CastToFunc(SpecificationAdapter<T> specification)
        {
            throw new NotImplementedException();
        }

        public override SpecificationAdapter<T> CreateSpecification()
        {
            return new SpecificationAdapter<T>(
        }
    }
}
