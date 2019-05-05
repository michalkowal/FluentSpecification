using System;
using FluentSpecification.Integration.Tests.Data;
using Xunit;

namespace FluentSpecification.Integration.Tests
{
    [Collection("EF Collection")]
    public abstract class BaseEfCoreTests : IDisposable
    {
        protected BaseEfCoreTests(DatabaseFixture fixture)
        {
            Context = new EfCoreDbContext(fixture.Options);
        }

        internal EfCoreDbContext Context { get; }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}