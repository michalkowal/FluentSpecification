using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class TrueSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void InvalidCandidate_ReturnFalse()
            {
                var sut = new TrueSpecification();

                var result = sut.IsSatisfiedBy(false);

                Assert.False(result);
            }

            [Fact]
            public void ValidCandidate_ReturnTrue()
            {
                var sut = new TrueSpecification();

                var result = sut.IsSatisfiedBy(true);

                Assert.True(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Fact]
            public void InvalidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "TrueSpecification+Failed",
                    new SpecificationInfo(typeof(TrueSpecification), false, "Value is False"));
                var sut = new TrueSpecification();

                var overall = sut.IsSatisfiedBy(false, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ValidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("TrueSpecification");
                var sut = new TrueSpecification();

                var overall = sut.IsSatisfiedBy(true, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}