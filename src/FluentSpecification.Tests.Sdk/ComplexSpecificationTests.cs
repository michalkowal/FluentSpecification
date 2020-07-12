using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Tests.Sdk.Data;
using FluentSpecification.Tests.Sdk.Framework;
using System.Globalization;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    public abstract partial class ComplexSpecificationTests<T> : BaseSpecificationTests
        where T : ComplexSpecificationTests<T>
    {
        protected ComplexSpecificationTests()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        }

        protected virtual TSpecification CreateSpecification<TCandidate, TSpecification>(IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            return factory.CreateSpecification();
        }

        protected virtual IComplexSpecification<TCandidate> CreateSpecification<TCandidate>(SpecificationFactory<TCandidate> factory)
        {
            return factory.Create();
        }

        [Theory]
        [Trait("Category", "ExpressionOperator")]
        [SpecificationFactoryData]
        public void ExpressionOperator_CastCorrectSpecification_ReturnExpression<TCandidate, TSpecification>(
            IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            var sut = CreateSpecification(factory);
            Assert_ExpressionOperator_EqualsGetExpression(sut, factory.CastToExpression);
        }

        [Theory]
        [Trait("Category", "ExpressionOperator")]
        [SpecificationFactoryData]
        public void ExpressionOperator_CastNull_ReturnNull<TCandidate, TSpecification>(
            IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            Assert_ExpressionOperator_EqualsNull<TCandidate, TSpecification>(factory.CastToExpression);
        }

        [Theory]
        [Trait("Category", "AbstractExpressionOperator")]
        [SpecificationFactoryData]
        public void AbstractExpressionOperator_CastCorrectSpecification_ReturnExpression<TCandidate, TSpecification>(
            IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            var sut = CreateSpecification(factory);
            Assert_AbstractExpressionOperator_EqualsGetExpression<TCandidate, TSpecification>(sut, factory.CastToAbstractExpression);
        }

        [Theory]
        [Trait("Category", "AbstractExpressionOperator")]
        [SpecificationFactoryData]
        public void AbstractExpressionOperator_CastNull_ReturnNull<TCandidate, TSpecification>(
            IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            Assert_AbstractExpressionOperator_EqualsNull<TCandidate, TSpecification>(factory.CastToAbstractExpression);
        }

        [Theory]
        [Trait("Category", "FuncOperator")]
        [SpecificationFactoryData]
        public void FuncOperator_CastCorrectSpecification_ReturnIsSatisfiedByFunction<TCandidate, TSpecification>(
            IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            var sut = CreateSpecification(factory);
            Assert_FuncOperator_EqualsIsSatisfiedBy(sut, factory.CastToFunc);
        }

        [Theory]
        [Trait("Category", "FuncOperator")]
        [SpecificationFactoryData]
        public void FuncOperator_CastNull_ReturnNull<TCandidate, TSpecification>(
            IComplexSpecificationFactory<TCandidate, TSpecification> factory)
            where TSpecification : class, IComplexSpecification<TCandidate>
        {
            Assert_FuncOperator_EqualsNull<TCandidate, TSpecification>(factory.CastToFunc);
        }
    }
}
