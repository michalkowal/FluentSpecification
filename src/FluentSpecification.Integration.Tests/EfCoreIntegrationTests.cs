using System.Linq;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Integration.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Integration.Tests
{
    [Collection("EF Collection")]
    public class EfCoreIntegrationTests : BaseEfCoreTests
    {
        public EfCoreIntegrationTests(DatabaseFixture fixture)
            : base(fixture)
        {
        }

        [Theory]
        [CorrectData(typeof(EfCoreIntegrationData))]
        public void AllSpecifications_ReturnOneCustomer(ILinqSpecification<Customer> specification, int expectedId)
        {
            var sut = specification.GetExpression();

            var result = Context.Customers
                .Where(sut).ToList();

            Assert.Single(result);
            Assert.Equal(expectedId, result.First().CustomerId);
        }

        [Theory]
        [IncorrectData(typeof(EfCoreIntegrationData))]
        public void AllSpecificationsNegation_ReturnTwoCustomers(ILinqSpecification<Customer> specification, int first,
            int second)
        {
            var sut = specification.GetExpression();

            var result = Context.Customers
                .Where(sut).ToList();

            Assert.Equal(2, result.Count);
            Assert.Equal(first, result.First().CustomerId);
            Assert.Equal(second, result.Last().CustomerId);
        }
    }
}