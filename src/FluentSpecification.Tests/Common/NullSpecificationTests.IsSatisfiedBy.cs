using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class NullSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void NotNullCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<string>();

                var result = sut.IsSatisfiedBy("");

                Assert.False(result);
            }

            [Fact]
            public void NullableCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<int?>();

                var result = sut.IsSatisfiedBy(null);

                Assert.True(result);
            }

            [Fact]
            public void NullCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<string>();

                var result = sut.IsSatisfiedBy(null);

                Assert.True(result);
            }

            [Fact]
            public void ValueType_ReturnFalse()
            {
                var sut = new NullSpecification<int>();

                var result = sut.IsSatisfiedBy(0);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Fact]
            public void NotNullCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "NullSpecification<String>+Failed",
                    new FailedSpecification(typeof(NullSpecification<string>), "", "Object is not null"));
                var sut = new NullSpecification<string>();

                var overall = sut.IsSatisfiedBy("", out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullableCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NullSpecification<Nullable<Int32>>");
                var sut = new NullSpecification<int?>();

                var overall = sut.IsSatisfiedBy(null, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NullSpecification<String>");
                var sut = new NullSpecification<string>();

                var overall = sut.IsSatisfiedBy(null, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ValueTypeCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "NullSpecification<Int32>+Failed",
                    new FailedSpecification(typeof(NullSpecification<int>), 0, "Object is not null"));
                var sut = new NullSpecification<int>();

                var overall = sut.IsSatisfiedBy(0, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}