using System;
using FluentSpecification.Integration.Tests.Data;
using Xunit;

namespace FluentSpecification.Integration.Tests
{
    [Collection("EF Collection")]
    public abstract class BaseEfTests : IDisposable
    {
        protected BaseEfTests(DatabaseFixture fixture)
        {
            Context = new EfDbContext(fixture.Connection);
        }

        internal EfDbContext Context { get; }

        public virtual void Dispose()
        {
            Context.Dispose();
        }
    }
}