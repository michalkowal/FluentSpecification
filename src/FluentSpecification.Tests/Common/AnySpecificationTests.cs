using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using FluentSpecification.Tests.Sdk.Framework;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    [SpecificationData(typeof(AnyData))]
    [SpecificationFactoryData(typeof(AnyFactory))]
    public class AnySpecificationTests : ComplexSpecificationTests<AnySpecificationTests>
    {
        [Fact]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        [Trait("Category", "Constructor")]
        public void Constructor_NullSpecification_ArgumentNullException()
        {
            var exception = Record.Exception(() =>
                new AnySpecification<int[], int>(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "GetExpression")]
        public void GetExpression_CorrectComplexSpecification_ReturnExpressionForAny()
        {
            ISpecification<string> specification = MockComplexSpecification<string>.True();
            var sut = new AnySpecification<string[], string>(specification);

            var sutExpression = sut.GetExpression();
            var result = sutExpression.ToString();

            Assert.Equal(@"candidate => ((candidate != null) AndAlso candidate.Any(candidate => True))", result);
        }

        [Fact]
        [Trait("Category", "GetExpression")]
        public void GetExpression_InvokeNullCollectionLinqToEntities_Exception()
        {
            var specification = MockComplexSpecification<int>.True();
            var sut = new AnySpecification<int[], int>(specification, true);
            var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

            Assert.NotNull(exception);
            Assert.IsType<ArgumentNullException>(exception);
        }

        [Fact]
        [Trait("Category", "GetExpression")]
        public void GetExpression_InvokeRelatedTypes_NoException()
        {
            var specification = MockComplexSpecification<IEnumerable<int>>.True();
            var exception = Record.Exception(() =>
            {
                var sut = new AnySpecification<IEnumerable<EquatableFakeType>, EquatableFakeType>(specification);
                sut.GetExpression().Compile().Invoke(new EquatableFakeType[0]);
            });

            Assert.Null(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedBy_NullCollectionLinqToEntities_NoException()
        {
            var specification = MockComplexSpecification<int>.True();
            var sut = new AnySpecification<int[], int>(specification, true);
            var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

            Assert.Null(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedBy_RelatedTypes_NoException()
        {
            var specification = MockComplexSpecification<IEnumerable<int>>.True();
            var exception = Record.Exception(() =>
            {
                var sut = new AnySpecification<IEnumerable<EquatableFakeType>, EquatableFakeType>(specification);
                sut.IsSatisfiedBy(new EquatableFakeType[0]);
            });

            Assert.Null(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedByValidation_NullCollectionLinqToEntities_NoException()
        {
            var specification = MockComplexSpecification<int>.True();
            var sut = new AnySpecification<int[], int>(specification, true);
            var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

            Assert.Null(exception);
        }

        [Fact]
        [Trait("Category", "IsSatisfiedBy")]
        public void IsSatisfiedByValidation_RelatedTypes_NoException()
        {
            var specification = MockComplexSpecification<IEnumerable<int>>.True();
            var exception = Record.Exception(() =>
            {
                var sut = new AnySpecification<IEnumerable<EquatableFakeType>, EquatableFakeType>(specification);
                sut.IsSatisfiedBy(new EquatableFakeType[0], out _);
            });

            Assert.Null(exception);
        }
    }
}