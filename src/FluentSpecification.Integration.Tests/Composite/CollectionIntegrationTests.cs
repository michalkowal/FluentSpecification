using System.Linq;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;
using FluentSpecification.Integration.Tests.Logic;
using Xunit;

namespace FluentSpecification.Integration.Tests.Composite
{
    public partial class CollectionIntegrationTests
    {
        public CollectionIntegrationTests()
        {
            _fixture = new DataFixture();
        }

        private readonly DataFixture _fixture;

        [Fact]
        public void MultipleAndSpecifications_ReturnOneItem()
        {
            var sut = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"));

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Single(result);
            Assert.Equal(5, result.First().Id);
            Assert.Equal("Defqon.1 Australia", result.First().Code);
        }

        [Fact]
        public void MultipleDifferentSpecifications_ReturnOneItem()
        {
            var sut = new ActiveItemsSpecification()
                .Or(new ItemBigIdSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not());

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Single(result);
            Assert.Equal(5, result.First().Id);
            Assert.Equal("Defqon.1 Australia", result.First().Code);
        }

        [Fact]
        public void MultipleOrSpecifications_ReturnTwoItems()
        {
            var sut = new CodeStartsWithSpecification("Qlimax")
                .Or(new CodeStartsWithSpecification("Nothing"))
                .Or(new ItemBigIdSpecification());

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Equal(2, result.Count);
            Assert.Equal(2, result.First().Id);
            Assert.Equal("Qlimax", result.First().Code);
            Assert.Equal(100, result.Last().Id);
            Assert.Equal("Sensation Black", result.Last().Code);
        }

        [Fact]
        public void MultipleSpecificationsWithGroup_ReturnOneItem()
        {
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"));

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Single(result);
            Assert.Equal(9, result.First().Id);
            Assert.Equal("Qountdown", result.First().Code);
        }

        [Fact]
        public void MultipleSpecificationsWithGroupNegation_ReturnOneItem()
        {
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications.Not())
                .And(new NameContainsSpecification("City On Earth"));

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Single(result);
            Assert.Equal(4, result.First().Id);
            Assert.Equal("In Qontrol", result.First().Code);
        }

        [Fact]
        public void MultipleSpecificationsWIthNotLinqSpecification_ReturnOneItem()
        {
            var sut = new FavoriteItemSpecification()
                .Not()
                .And(new ActiveItemsSpecification().Not())
                .And(new ItemBigIdSpecification());

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Single(result);
            Assert.Equal(100, result.First().Id);
            Assert.Equal("Sensation Black", result.First().Code);
        }

        [Fact]
        public void NegationMultipleDifferentSpecifications_ReturnAllExceptOneItem()
        {
            var sut = new ActiveItemsSpecification()
                .Or(new ItemBigIdSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not())
                .Not();

            var notExpected = _fixture.Events.Single(i => i.Id == 5);
            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Equal(9, result.Count);
            Assert.DoesNotContain(notExpected, result);
        }

        [Fact]
        public void NegationMultipleSpecifications_ReturnAllExceptOneItem()
        {
            var sut = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"))
                .Not();

            var notExpected = _fixture.Events.Single(i => i.Id == 5);
            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Equal(9, result.Count);
            Assert.DoesNotContain(notExpected, result);
        }

        [Fact]
        public void NegationMultipleSpecificationsWithGroup_ReturnAllExceptOneItem()
        {
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"))
                .Not();

            var notExpected = _fixture.Events.Single(i => i.Id == 9);
            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Equal(9, result.Count);
            Assert.DoesNotContain(notExpected, result);
        }

        [Fact]
        public void NotLinqSpecification_ReturnOneItem()
        {
            var sut = new FavoriteItemSpecification();

            var result = _fixture.Events
                .Where(item => sut.IsSatisfiedBy(item)).ToList();

            Assert.Single(result);
            Assert.Equal(1, result.First().Id);
            Assert.Equal("Defqon.1", result.First().Code);
        }
    }
}