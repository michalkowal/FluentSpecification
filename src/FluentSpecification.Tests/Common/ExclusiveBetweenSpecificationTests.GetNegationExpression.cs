using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class ExclusiveBetweenSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(ExclusiveBetweenData), AsNegation = true)]
            public void InvokeNotExclusiveBetweenCandidate_ReturnTrue<T>(T candidate, T from, T to,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new ExclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ExclusiveBetweenData), AsNegation = true)]
            public void InvokeExclusiveBetweenCandidate_ReturnFalse<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new ExclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(ExclusiveBetweenNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? from, int? to)
            {
                var sut = new ExclusiveBetweenSpecification<int?>(from, to);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(ExclusiveBetweenNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? from, int? to)
            {
                var sut = new ExclusiveBetweenSpecification<int?>(from, to);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}