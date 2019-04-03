using System.Linq;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;
using FluentSpecification.Integration.Tests.Logic;
using Xunit;

namespace FluentSpecification.Integration.Tests.Composite
{
    [Collection("EF Collection")]
    public class EfIntegrationTests : BaseEfTests
    {
        public EfIntegrationTests(DatabaseFixture fixture) :
            base(fixture)
        {
        }

        [Fact]
        public void MultipleAndSpecifications_ReturnOneItem()
        {
            var specification = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"));
            var sut = specification.GetExpression();

            var result = Context.Events.Where(sut).ToList();

            Assert.Single(result);
            Assert.Equal(5, result.First().Id);
            Assert.Equal("Defqon.1 Australia", result.First().Code);
        }

        [Fact]
        public void MultipleDifferentSpecifications_ReturnOneItem()
        {
            var specification = new ActiveItemsSpecification()
                .Or(new ItemBigIdSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not());
            var sut = specification.GetExpression();

            var result = Context.Events.Where(sut).ToList();

            Assert.Single(result);
            Assert.Equal(5, result.First().Id);
            Assert.Equal("Defqon.1 Australia", result.First().Code);
        }

        [Fact]
        public void MultipleOrSpecifications_ReturnTwoItems()
        {
            var specification = new CodeStartsWithSpecification("Qlimax")
                .Or(new CodeStartsWithSpecification("Nothing"))
                .Or(new ItemBigIdSpecification());
            var sut = specification.GetExpression();

            var result = Context.Events.Where(sut).ToList();

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
            var specification = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"));
            var sut = specification.GetExpression();

            var result = Context.Events.Where(sut).ToList();

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
            var specification = notActiveItems
                .And(codeSpecifications.Not())
                .And(new NameContainsSpecification("City On Earth"));
            var sut = specification.GetExpression();

            var result = Context.Events.Where(sut).ToList();

            Assert.Single(result);
            Assert.Equal(4, result.First().Id);
            Assert.Equal("In Qontrol", result.First().Code);
        }

        [Fact]
        public void NegationMultipleDifferentSpecifications_ReturnAllExceptOneItem()
        {
            var specification = new ActiveItemsSpecification()
                .Or(new ItemBigIdSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not())
                .Not();
            var sut = specification.GetExpression();

            var notExpected = Context.Events.Single(i => i.Id == 5);
            var result = Context.Events.Where(sut).ToList();

            Assert.Equal(9, result.Count);
            Assert.DoesNotContain(notExpected, result);
        }

        [Fact]
        public void NegationMultipleSpecifications_ReturnAllExceptOneItem()
        {
            var specification = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"))
                .Not();
            var sut = specification.GetExpression();

            var notExpected = Context.Events.Single(i => i.Id == 5);
            var result = Context.Events.Where(sut).ToList();

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
            var specification = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"))
                .Not();
            var sut = specification.GetExpression();

            var notExpected = Context.Events.Single(i => i.Id == 9);
            var result = Context.Events.Where(sut).ToList();

            Assert.Equal(9, result.Count);
            Assert.DoesNotContain(notExpected, result);
        }
    }
}