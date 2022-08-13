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
    public partial class AnySpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(AnyData))]
            public void InvokeAnyElementsValid_ReturnTrue<T, TType>(T candidate,
                Expression<Func<TType, bool>> expression)
                where T : IEnumerable<TType>
            {
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AnySpecification<T, TType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(AnyData))]
            public void InvokeNotAnyElementsValid_ReturnFalse<T, TType>(T candidate,
                Expression<Func<TType, bool>> expression)
                where T : IEnumerable<TType>
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var specification = new MockComplexSpecification<TType>(expression);
                var sut = new AnySpecification<T, TType>(specification);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void CorrectComplexSpecification_ReturnExpressionForAny()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AnySpecification<string[], string>(specification);

                var sutExpression = sut.GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(@"candidate => ((candidate != null) AndAlso candidate.Any(candidate => True))", result);
            }

            [Fact]
            public void InvokeNullCollectionLinqToEntities_Exception()
            {
                var specification = MockComplexSpecification<int>.True();
                var sut = new AnySpecification<int[], int>(specification, true);
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
                    var sut = new AnySpecification<IEnumerable<EquatableFakeType>, EquatableFakeType>(specification);
                    sut.GetExpression().Compile().Invoke(Array.Empty<EquatableFakeType>());
                });

                Assert.Null(exception);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnBaseExpressionAsAbstractExpression()
            {
                ISpecification<string> specification = MockComplexSpecification<string>.True();
                var sut = new AnySpecification<string[], string>(specification);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}