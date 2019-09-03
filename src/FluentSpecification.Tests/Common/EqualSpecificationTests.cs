using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    [UsedImplicitly]
    public partial class EqualSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(EqualData))]
            public void InvokeEqualCandidate_ReturnTrue<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualData))]
            public void InvokeNotEqualCandidate_ReturnFalse<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(EqualNullableData))]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualNullableData))]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new EqualSpecification<string>(null);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}