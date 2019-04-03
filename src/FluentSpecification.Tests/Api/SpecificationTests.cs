using System;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests : IDisposable
    {
        public SpecificationTests()
        {
            Specification.LinqToEntities = true;
        }

        public void Dispose()
        {
            Specification.LinqToEntities = false;
        }
    }
}