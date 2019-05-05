using Xunit;

namespace FluentSpecification.Integration.Tests.Data
{
    [CollectionDefinition("EF Collection")]
    public class DatabaseFixtureCollection : ICollectionFixture<DatabaseFixture>
    {
    }
}