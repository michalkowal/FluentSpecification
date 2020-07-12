using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions.Validation;
using Xunit;

namespace FluentSpecification.Tests.Sdk.Data.Validation
{
    public class ExpectedSpecificationInfo : IEquatable<SpecificationInfo>
    {
        public bool Result { get; set; }

        public Type SpecificationType { get; set; }

        public bool IsNegation { get; set; }

        public Dictionary<string, object> Parameters { get; set; }

        public object Candidate { get; set; }

        public List<string> Errors { get; set; }

        public bool Equals(SpecificationInfo other)
        {
            Assert.NotNull(other);

            Assert.Equal(Result, other.Result);
            Assert.Equal(SpecificationType, other.SpecificationType);
            Assert.Equal(IsNegation, other.IsNegation);

            Assert.Equal(Errors.Count, other.Errors.Count);
            Assert.Equal(Errors, other.Errors);

            Assert.Equal(Candidate, other.Candidate);

            Assert.Equal(Parameters.Count, other.Parameters.Count);
            Assert.Equal(Parameters, other.Parameters);

            return true;
        }
    }
}
