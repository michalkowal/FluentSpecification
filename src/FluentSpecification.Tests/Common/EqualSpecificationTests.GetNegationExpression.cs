using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class EqualSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(EqualData), AsNegation = true)]
            public void InvokeNotEqualCandidate_ReturnTrue<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualData), AsNegation = true)]
            public void InvokeEqualCandidate_ReturnFalse<T>(T candidate, T expected, IEqualityComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new EqualSpecification<T>(expected, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(EqualNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(EqualNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? expected)
            {
                var sut = new EqualSpecification<int?>(expected);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}