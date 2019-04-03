using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class NullSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Fact]
            public void NotNullCandidate_ReturnTrue()
            {
                var sut = new NullSpecification<string>();

                var result = sut.IsNotSatisfiedBy("");

                Assert.True(result);
            }

            [Fact]
            public void NullableCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<int?>();

                var result = sut.IsNotSatisfiedBy(null);

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_ReturnFalse()
            {
                var sut = new NullSpecification<string>();

                var result = sut.IsNotSatisfiedBy(null);

                Assert.False(result);
            }

            [Fact]
            public void ValueType_ReturnTrue()
            {
                var sut = new NullSpecification<int>();

                var result = sut.IsNotSatisfiedBy(0);

                Assert.True(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Fact]
            public void NotNullCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NotNullSpecification<String>");
                var sut = new NullSpecification<string>();

                var overall = sut.IsNotSatisfiedBy("", out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullableCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "NotNullSpecification<Nullable<Int32>>+Failed",
                    new FailedSpecification(typeof(NullSpecification<int?>), (object) null, "Object is null"));
                var sut = new NullSpecification<int?>();

                var overall = sut.IsNotSatisfiedBy(null, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "NotNullSpecification<String>+Failed",
                    new FailedSpecification(typeof(NullSpecification<string>), (object) null, "Object is null"));
                var sut = new NullSpecification<string>();

                var overall = sut.IsNotSatisfiedBy(null, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ValueTypeCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NotNullSpecification<Int32>");
                var sut = new NullSpecification<int>();

                var overall = sut.IsNotSatisfiedBy(0, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}