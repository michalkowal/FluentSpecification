using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class MatchSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void InvalidCandidate_ReturnFalse()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-261";
                var sut = new MatchSpecification(pattern);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_ReturnFalse()
            {
                var pattern = "^[0-9]{4}-[0-9]{2}-[0-9]{2}$";
                var sut = new MatchSpecification(pattern);

                var result = sut.IsSatisfiedBy(null);

                Assert.False(result);
            }

            [Fact]
            public void ValidCandidate_ReturnTrue()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-26";
                var sut = new MatchSpecification(pattern);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Fact]
            public void InvalidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "MatchSpecification+Failed",
                    new FailedSpecification(typeof(MatchSpecification), new Dictionary<string, object>
                    {
                        {"Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"}
                    }, (object) "2019-02-261", "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"));
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-261";
                var sut = new MatchSpecification(pattern);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "MatchSpecification+Failed",
                    new FailedSpecification(typeof(MatchSpecification), new Dictionary<string, object>
                    {
                        {"Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"}
                    }, (object) null, "String not match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"));
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var sut = new MatchSpecification(pattern);

                var overall = sut.IsSatisfiedBy(null, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ValidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("MatchSpecification");
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-26";
                var sut = new MatchSpecification(pattern);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}