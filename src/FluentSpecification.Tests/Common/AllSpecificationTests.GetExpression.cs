using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class AllSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(AllData))]
            public void InvokeAllElementsValid_ReturnTrue<T, TType>(T candidate,
                Expression<Func<TType, bool>> expression)
                where T : IEnumerable<TType>
            {
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AllSpecification<T, TType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AllData))]
            public void InvokeNotAllElementsValid_ReturnFalse<T, TType>(T candidate,
                Expression<Func<TType, bool>> expression)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AllSpecification<T, TType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void CorrectComplexSpecification_ReturnExpressionForAll()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AllSpecification<string[], string>(specification);

                var sutExpression = sut.GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(@"candidate => ((candidate != null) AndAlso candidate.All(candidate => True))", result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var specification = MockComplexSpecification<int>.True();
                var sut = new AllSpecification<int[], int>(specification, true);
                var exception = Record.Exception(() => sut.GetExpression().Compile().Invoke(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void InvokeRelatedTypes_NoException()
            {
                var specification = MockComplexSpecification<IEnumerable<int>>.True();
                var exception = Record.Exception(() =>
                {
                    var sut = new AllSpecification<IEnumerable<EquatableFakeType>, EquatableFakeType>(specification);
                    sut.GetExpression().Compile().Invoke(Array.Empty<EquatableFakeType>());
                });

                Assert.Null(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnBaseExpressionAsAbstractExpression()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AllSpecification<string[], string>(specification);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}