using System;
using FluentSpecification.Abstractions.Validation;
using Xunit;

namespace FluentSpecification.Tests.Sdk.Data.Validation
{
    public struct ExpectedSpecificationTrace : IEquatable<SpecificationTrace>
    {
        public string FullTrace { get; set; }
        public string ShortTrace { get; set; }

        public bool Equals(SpecificationTrace other)
        {
            Assert.Equal(FullTrace, other.FullTrace);
            Assert.Equal(ShortTrace, other.ShortTrace);

            return true;
        }
    }
}
