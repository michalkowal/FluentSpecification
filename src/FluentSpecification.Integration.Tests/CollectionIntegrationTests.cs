using System.Linq;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Integration.Tests.Data;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Integration.Tests
{
    public partial class CollectionIntegrationTests
    {
        private readonly DataFixture _fixture;

        public CollectionIntegrationTests()
        {
            _fixture = new DataFixture();
        }

        [Theory]
        [CorrectData(typeof(IntegrationData))]
        public void AllSpecifications_ReturnOneCustomer(ISpecification<Customer> sut, int expectedId)
        {
            var result = _fixture.Customers
                .Where(sut.IsSatisfiedBy).ToList();

            Assert.Single(result);
            Assert.Equal(expectedId, result.First().CustomerId);
        }

        [Theory]
        [IncorrectData(typeof(IntegrationData))]
        public void AllSpecificationsNegation_ReturnTwoCustomers(ISpecification<Customer> sut, int first, int second)
        {
            var result = _fixture.Customers
                .Where(sut.IsSatisfiedBy).ToList();

            Assert.Equal(2, result.Count);
            Assert.Equal(first, result.First().CustomerId);
            Assert.Equal(second, result.Last().CustomerId);
        }
    }
}