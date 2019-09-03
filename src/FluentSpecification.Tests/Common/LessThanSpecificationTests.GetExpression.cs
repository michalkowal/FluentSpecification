using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LessThanSpecificationTests
    {
        public class GetExpression
        {
            [Theory]
            [CorrectData(typeof(LessThanData))]
            public void InvokeLessThanCandidate_ReturnTrue<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanData))]
            public void InvokeNotLessThanCandidate_ReturnFalse<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(LessThanNullableData))]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? lessThan)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanNullableData))]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? lessThan)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var result = sut.GetExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NonGenericILinqSpecification_ReturnExpressionAsAbstractExpression()
            {
                var sut = new LessThanSpecification<string>(null);

                var expected = sut.GetExpression().ToString();
                var sutExpression = ((ILinqSpecification) sut).GetExpression();
                var result = sutExpression.ToString();

                Assert.Equal(expected, result);
            }
        }
    }
}