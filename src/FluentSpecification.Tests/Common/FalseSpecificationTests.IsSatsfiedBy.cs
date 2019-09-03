using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class FalseSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void InvalidCandidate_ReturnTrue()
            {
                var sut = new FalseSpecification();

                var result = sut.IsSatisfiedBy(false);

                Assert.True(result);
            }

            [Fact]
            public void ValidCandidate_ReturnFalse()
            {
                var sut = new FalseSpecification();

                var result = sut.IsSatisfiedBy(true);

                Assert.False(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Fact]
            public void InvalidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("FalseSpecification");
                var sut = new FalseSpecification();

                var overall = sut.IsSatisfiedBy(false, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ValidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "FalseSpecification+Failed",
                    new SpecificationInfo(typeof(FalseSpecification), true, "Value is True"));
                var sut = new FalseSpecification();

                var overall = sut.IsSatisfiedBy(true, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}