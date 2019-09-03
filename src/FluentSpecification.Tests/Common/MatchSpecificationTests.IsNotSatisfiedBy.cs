using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Tests.Common
{
    public partial class MatchSpecificationTests
    {
        public class IsNotSatisfiedBy
        {
            [Fact]
            public void InvalidCandidate_ReturnFalse()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-26";
                var sut = new MatchSpecification(pattern);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_ReturnTrue()
            {
                var pattern = "^[0-9]{4}-[0-9]{2}-[0-9]{2}$";
                var sut = new MatchSpecification(pattern);

                var result = sut.IsNotSatisfiedBy(null);

                Assert.True(result);
            }

            [Fact]
            public void ValidCandidate_ReturnTrue()
            {
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-261";
                var sut = new MatchSpecification(pattern);

                var result = sut.IsNotSatisfiedBy(candidate);

                Assert.True(result);
            }
        }

        public class IsNotSatisfiedBySpecificationResult
        {
            [Fact]
            public void InvalidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult(false, "NotMatchSpecification+Failed",
                    new SpecificationInfo(typeof(MatchSpecification), new Dictionary<string, object>
                    {
                        {"Pattern", "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$"}
                    }, (object) "2019-02-26", "String match pattern [^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$]"));
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-26";
                var sut = new MatchSpecification(pattern);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NotMatchSpecification");
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var sut = new MatchSpecification(pattern);

                var overall = sut.IsNotSatisfiedBy(null, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void ValidCandidate_ReturnExpectedResultObject()
            {
                var expected = new SpecificationResult("NotMatchSpecification");
                var pattern = "^[1-9][0-9]{3}-[0-9]{2}-[0-9]{2}$";
                var candidate = "2019-02-261";
                var sut = new MatchSpecification(pattern);

                var overall = sut.IsNotSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }
        }
    }
}