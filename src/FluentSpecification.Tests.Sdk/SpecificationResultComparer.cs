using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;
using Xunit;

// ReSharper disable PossibleNullReferenceException
namespace FluentSpecification.Tests.Sdk
{
    [PublicAPI]
    public class SpecificationResultComparer : IEqualityComparer<SpecificationResult>
    {
        private readonly object _candidate;

        private readonly FailedSpecificationComparer _failedSpecificationComparer =
            new FailedSpecificationComparer();

        private readonly IReadOnlyDictionary<string, object> _parameters;

        public SpecificationResultComparer(object candidate = null,
            IReadOnlyDictionary<string, object> parameters = null)
        {
            _candidate = candidate;
            _parameters = parameters ?? new Dictionary<string, object>();
        }

        public bool Equals(SpecificationResult x, SpecificationResult y)
        {
            _failedSpecificationComparer.Candidate = _candidate;
            _failedSpecificationComparer.Parameters = _parameters;

            Assert.Equal(x.OverallResult, y.OverallResult);
            Assert.Equal(x.TotalSpecificationsCount, y.TotalSpecificationsCount);
            Assert.Equal(x.FailedSpecificationsCount, y.FailedSpecificationsCount);
            Assert.Equal(x.Trace, y.Trace);
            if (_candidate is DateTime)
                for (var i = 0; i < x.Errors.Count; i++)
                    Assert.Matches(x.Errors[i], y.Errors[i]);
            else
                Assert.Equal(x.Errors, y.Errors.Select(e => Regex.Replace(e, "(?<=[0-9]),(?=[0-9])", ".")).ToArray());
            Assert.Equal(x.FailedSpecifications, y.FailedSpecifications, _failedSpecificationComparer);

            return true;
        }

        public int GetHashCode(SpecificationResult obj)
        {
            return obj.OverallResult.GetHashCode() ^
                   obj.TotalSpecificationsCount.GetHashCode() ^
                   obj.Trace.GetHashCode() ^
                   obj.FailedSpecifications.GetHashCode();
        }
    }
}