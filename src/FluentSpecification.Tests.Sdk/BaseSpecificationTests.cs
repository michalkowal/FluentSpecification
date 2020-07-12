using FluentSpecification.Abstractions.Generic;
using System;
using System.Linq.Expressions;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class BaseSpecificationTests
    {
        protected void Assert_ExpressionOperator_EqualsGetExpression<TCandidate, TSpecification>(TSpecification sut, 
            Func<TSpecification, Expression<Func<TCandidate, bool>>> cast)
            where TSpecification : ILinqSpecification<TCandidate>
        {
            Assert_Cast_Equals(sut, sut.GetExpression(), cast);
        }

        protected void Assert_ExpressionOperator_EqualsNull<TCandidate, TSpecification>(Func<TSpecification, Expression<Func<TCandidate, bool>>> cast)
            where TSpecification : class, ILinqSpecification<TCandidate>
        {
            Assert_Cast_EqualsNull(cast);
        }

        protected void Assert_AbstractExpressionOperator_EqualsGetExpression<TCandidate, TSpecification>(TSpecification sut, 
            Func<TSpecification, Expression> cast)
            where TSpecification : ILinqSpecification<TCandidate>
        {
            Assert_Cast_Equals(sut, sut.GetExpression(), cast);
        }

        protected void Assert_AbstractExpressionOperator_EqualsNull<TCandidate, TSpecification>(Func<TSpecification, Expression> cast)
            where TSpecification : class, ILinqSpecification<TCandidate>
        {
            Assert_Cast_EqualsNull(cast);
        }

        protected void Assert_FuncOperator_EqualsIsSatisfiedBy<TCandidate, TSpecification>(TSpecification sut, 
            Func<TSpecification, Func<TCandidate, bool>> cast)
            where TSpecification : ISpecification<TCandidate>
        {
            Assert_Cast_Equals(sut, sut.IsSatisfiedBy, cast);
        }

        protected void Assert_FuncOperator_EqualsNull<TCandidate, TSpecification>(Func<TSpecification, Func<TCandidate, bool>> cast)
            where TSpecification : class, ISpecification<TCandidate>
        {
            Assert_Cast_EqualsNull(cast);
        }

        private void Assert_Cast_Equals<TSpecification, TCast>(TSpecification sut, TCast expected, Func<TSpecification, TCast> cast)
        {
            var result = cast(sut);

            Assert.Equal(expected.ToString(), result.ToString());
        }

        private void Assert_Cast_EqualsNull<TSpecification, TCast>(Func<TSpecification, TCast> cast)
            where TSpecification : class
        {
            TSpecification sut = null;

            var result = cast(sut);

            Assert.Null(result);
        }
    }
}
