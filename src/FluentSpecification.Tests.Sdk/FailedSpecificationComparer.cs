using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Tests.Sdk
{
    [PublicAPI]
    public class FailedSpecificationComparer : IEqualityComparer<FailedSpecification>
    {
        public object Candidate { get; set; }

        public IReadOnlyDictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

        public bool Equals(FailedSpecification x, FailedSpecification y)
        {
            if (ReferenceEquals(x, y))
                return true;
            Assert.NotNull(x);
            Assert.NotNull(y);

            Assert.Equal(x.SpecificationType, y.SpecificationType);
            if (Candidate is DateTime)
                for (var i = 0; i < x.Errors.Count; i++)
                    Assert.Matches(x.Errors[i], y.Errors[i]);
            else
                Assert.Equal(x.Errors, y.Errors.Select(e => Regex.Replace(e, "(?<=[0-9]),(?=[0-9])", ".")).ToArray());
            Assert.Equal(x.Candidate ?? Candidate, y.Candidate);

            var expectedParameters = x.Parameters.ToDictionary(k => k.Key, v => v.Value);
            if (Parameters.Count > 0)
                foreach (var subs in Parameters)
                    if (expectedParameters.ContainsKey(subs.Key))
                        expectedParameters[subs.Key] = subs.Value;

            Assert.Equal(expectedParameters, y.Parameters);

            return true;
        }

        public int GetHashCode(FailedSpecification obj)
        {
            return obj.SpecificationType.GetHashCode() ^
                   obj.Parameters.GetHashCode() ^
                   obj.Errors.GetHashCode();
        }
    }
}