using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class LessThanSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(LessThanData), AsNegation = true)]
            public void InvokeNotLessThanCandidate_ReturnTrue<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanData), AsNegation = true)]
            public void InvokeLessThanCandidate_ReturnFalse<T>(T candidate, T lessThan, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default;
                var sut = new LessThanSpecification<T>(lessThan, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(LessThanNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? lessThan)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(LessThanNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? lessThan)
            {
                var sut = new LessThanSpecification<int?>(lessThan);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}