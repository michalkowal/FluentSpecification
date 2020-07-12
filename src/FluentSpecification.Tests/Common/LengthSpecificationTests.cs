using System;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(LengthData))]
    [SpecificationFactoryData(typeof(LengthFactory))]
    public class LengthSpecificationTests : ComplexNegatableSpecificationTests<LengthSpecificationTests>
    {
        [Fact]
        [Trait("Category", "GetExpression")]
        public void GetExpression_InvokeNullCollectionLinqToEntities_Exception()
        {
            var sut = new LengthSpecification<int[]>(0, true);
            var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "GetNegationExpression")]
        public void GetNegationExpression_InvokeNullCollectionLinqToEntities_Exception()
        {
            var sut = new LengthSpecification<int[]>(0, true);
            var exception = Record.Exception(() => sut.GetNegationExpression().Compile().Invoke(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "IsNotSatisfiedBy")]
        public void IsNotSatisfiedBy_InvokeNullCollectionLinqToEntities_Exception()
        {
            var sut = new LengthSpecification<int[]>(0, true);
            var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "IsNotSatisfiedBy")]
        public void IsNotSatisfiedByValidation_InvokeNullCollectionLinqToEntities_Exception()
        {
            var sut = new LengthSpecification<int[]>(0, true);
            var exception = Record.Exception(() => sut.IsNotSatisfiedBy(null, out _));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedBy_InvokeNullCollectionLinqToEntities_Exception()
        {
            var sut = new LengthSpecification<int[]>(0, true);
            var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedByValidation_InvokeNullCollectionLinqToEntities_Exception()
        {
            var sut = new LengthSpecification<int[]>(0, true);
            var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }
    }
}