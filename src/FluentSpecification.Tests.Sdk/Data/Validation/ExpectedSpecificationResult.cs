using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using Xunit;

namespace FluentSpecification.Tests.Sdk.Data.Validation
{
    public class ExpectedSpecificationResult : IEquatable<SpecificationResult>
    {
        public int TotalSpecificationsCount { get; set; }

        public bool OverallResult { get; set; }

        public List<ExpectedSpecificationInfo> Specifications { get; set; }

        public List<ExpectedSpecificationInfo> FailedSpecifications { get; set; }

        public ExpectedSpecificationTrace Trace { get; set; }

        public int FailedSpecificationsCount { get; set; }

        public List<string> Errors { get; set; }

        public ExpectedSpecificationResult()
        {
            Specifications = new List<ExpectedSpecificationInfo>();
            FailedSpecifications = new List<ExpectedSpecificationInfo>();
            Errors = new List<string>();
        }

        public bool Equals(SpecificationResult other)
        {
            Assert.NotNull(other);

            Assert.Equal(OverallResult, other.OverallResult);
            Assert.Equal(TotalSpecificationsCount, other.TotalSpecificationsCount);
            Assert.Equal(FailedSpecificationsCount, other.FailedSpecificationsCount);
            Assert.True(Trace.Equals(other.Trace));

            Assert.Equal(Errors.Count, other.Errors.Count);
            Assert.Equal(Errors, other.Errors);
            
            Assert.Equal(Specifications.Count, other.Specifications.Count);
            for (var i = 0; i < Specifications.Count; i++)
                Assert.True(Specifications[i].Equals(other.Specifications[i]));

            Assert.Equal(FailedSpecifications.Count, other.FailedSpecifications.Count);
            for (var i = 0; i < FailedSpecifications.Count; i++)
                Assert.True(FailedSpecifications[i].Equals(other.FailedSpecifications[i]));

            return true;
        }
    }
}
