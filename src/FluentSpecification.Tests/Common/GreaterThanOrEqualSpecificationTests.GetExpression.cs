using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class GreaterThanOrEqualSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(GreaterThanOrEqualData))]
            public void InvokeGreaterThanOrEqualCandidate_ReturnTrue<T>(T candidate, T greaterThan,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new GreaterThanOrEqualSpecification<T>(greaterThan, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanOrEqualData))]
            public void InvokeNotGreaterThanOrEqualCandidate_ReturnFalse<T>(T candidate, T greaterThan,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new GreaterThanOrEqualSpecification<T>(greaterThan, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(GreaterThanOrEqualNullableData))]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanOrEqualSpecification<int?>(greaterThan);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanOrEqualNullableData))]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanOrEqualSpecification<int?>(greaterThan);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new GreaterThanOrEqualSpecification<string>(null);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}