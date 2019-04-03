using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class InclusiveBetweenSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(InclusiveBetweenData))]
            public void InvokeInclusiveBetweenCandidate_ReturnTrue<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenData))]
            public void InvokeNotInclusiveBetweenCandidate_ReturnFalse<T>(T candidate, T from, T to,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(InclusiveBetweenNullableData))]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenNullableData))]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new InclusiveBetweenSpecification<string>(null, null);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}