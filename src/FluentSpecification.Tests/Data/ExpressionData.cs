using System;
using System.Linq.Expressions;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.ExpressionSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class ExpressionData : SpecificationData
    {
        private void Valid<T>(T candidate, Expression<Func<T, bool>> expression)
        {
            AddValidWithResult<T, ExpressionValidResults>(
                candidate, new ExpressionFactory<T>(expression));
        }

        private void Invalid<T>(T candidate, Expression<Func<T, bool>> expression)
        {
            AddInvalidWithResult<T, ExpressionInvalidResults>(
                candidate, new ExpressionFactory<T>(expression));
        }

        public ExpressionData()
        {
            var dum = new object();

            Valid(dum, True<object>());
            Invalid(dum, False<object>());
        }

        private Expression<Func<T, bool>> True<T>()
        {
            return candidate => true;
        }

        private Expression<Func<T, bool>> False<T>()
        {
            return candidate => false;
        }

    }
}
