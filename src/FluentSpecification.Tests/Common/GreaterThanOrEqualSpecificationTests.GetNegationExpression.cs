using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class GreaterThanOrEqualSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(GreaterThanOrEqualData), AsNegation = true)]
            public void InvokeNotGreaterThanOrEqualCandidate_ReturnTrue<T>(T candidate, T greaterThan,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new GreaterThanOrEqualSpecification<T>(greaterThan, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanOrEqualData), AsNegation = true)]
            public void InvokeGreaterThanOrEqualCandidate_ReturnFalse<T>(T candidate, T greaterThan,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new GreaterThanOrEqualSpecification<T>(greaterThan, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(GreaterThanOrEqualNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanOrEqualSpecification<int?>(greaterThan);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(GreaterThanOrEqualNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? greaterThan)
            {
                var sut = new GreaterThanOrEqualSpecification<int?>(greaterThan);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}