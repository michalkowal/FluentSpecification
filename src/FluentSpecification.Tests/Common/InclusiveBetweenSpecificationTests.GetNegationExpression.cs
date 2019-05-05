using System.Collections.Generic;
using FluentSpecification.Common;
using FluentSpecification.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class InclusiveBetweenSpecificationTests
    {
        public class GetNegationExpression
        {
            [Theory]
            [CorrectData(typeof(InclusiveBetweenData), AsNegation = true)]
            public void InvokeNotInclusiveBetweenCandidate_ReturnTrue<T>(T candidate, T from, T to,
                IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenData), AsNegation = true)]
            public void InvokeInclusiveBetweenCandidate_ReturnFalse<T>(T candidate, T from, T to, IComparer<T> comparer)
            {
                candidate = candidate?.ToString() != "null" ? candidate : default(T);
                var sut = new InclusiveBetweenSpecification<T>(from, to, comparer);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }

            [Theory]
            [CorrectData(typeof(InclusiveBetweenNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnTrue(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.True(result);
            }

            [Theory]
            [IncorrectData(typeof(InclusiveBetweenNullableData), AsNegation = true)]
            public void InvokeNullableCandidate_ReturnFalse(int? candidate, int? from, int? to)
            {
                var sut = new InclusiveBetweenSpecification<int?>(from, to);

                var result = sut.GetNegationExpression().Compile().Invoke(candidate);

                Assert.False(result);
            }
        }
    }
}