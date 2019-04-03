using System.Linq;
using FluentSpecification.Core;
using FluentSpecification.Integration.Tests.Data;
using FluentSpecification.Integration.Tests.Logic;
using Xunit;

namespace FluentSpecification.Integration.Tests.Composite
{
    public partial class CollectionIntegrationTests
    {
        [Fact]
        public void MultipleAndSpecificationsCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 5,
                Code = "Defqon.1 Australia",
                Name = "All aboard, this is easy for real",
                IsArchival = false
            };
            var sut = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"));

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NameContainsSpecification", result.Trace);
        }

        [Fact]
        public void MultipleAndSpecificationsIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var sut = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"));

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(1, result.FailedSpecificationsCount);
            Assert.Equal(1, result.FailedSpecifications.Count);
            Assert.Equal(typeof(NameContainsSpecification), result.FailedSpecifications[0].SpecificationType);
            Assert.Equal(1, result.FailedSpecifications[0].Parameters.Count);
            Assert.Equal("easy", result.FailedSpecifications[0].Parameters["Filter"]);
            Assert.Equal(candidate, result.FailedSpecifications[0].Candidate);
            Assert.Equal(1, result.FailedSpecifications[0].Errors.Count);
            Assert.Equal("Item [Purple Tail] not contains: [easy]", result.FailedSpecifications[0].Errors[0]);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal("Item [Purple Tail] not contains: [easy]", result.Errors.First());
            Assert.False(result.OverallResult);
            Assert.Equal("ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NameContainsSpecification+Failed", result.Trace);
        }

        [Fact]
        public void MultipleDifferentSpecificationsCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 5,
                Code = "Defqon.1 Australia",
                Name = "All aboard, this is easy for real",
                IsArchival = false
            };
            var sut = new ItemBigIdSpecification()
                .Or(new ActiveItemsSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not());

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(4, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("ItemBigIdSpecification+Failed Or " +
                         "ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NotNameContainsSpecification", result.Trace);
        }

        [Fact]
        public void MultipleDifferentSpecificationsIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var sut = new ItemBigIdSpecification()
                .Or(new ActiveItemsSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not());

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(4, result.TotalSpecificationsCount);
            Assert.Equal(1, result.FailedSpecificationsCount);
            Assert.Equal(1, result.FailedSpecifications.Count);
            Assert.Equal(typeof(NameContainsSpecification), result.FailedSpecifications[0].SpecificationType);
            Assert.Equal(1, result.FailedSpecifications[0].Parameters.Count);
            Assert.Equal("Purple Tail", result.FailedSpecifications[0].Parameters["Filter"]);
            Assert.Equal(candidate, result.FailedSpecifications[0].Candidate);
            Assert.Equal(1, result.FailedSpecifications[0].Errors.Count);
            Assert.Equal("Item [Purple Tail] contains: [Purple Tail]", result.FailedSpecifications[0].Errors[0]);
            Assert.Equal(1, result.Errors.Count);
            Assert.Equal("Item [Purple Tail] contains: [Purple Tail]", result.Errors.First());
            Assert.False(result.OverallResult);
            Assert.Equal("ItemBigIdSpecification+Failed Or " +
                         "ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NotNameContainsSpecification+Failed", result.Trace);
        }

        [Fact]
        public void MultipleOrSpecificationsCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 2, Code = "Qlimax", Name = "The Power Of The Mind", IsArchival = false};
            var sut = new CodeStartsWithSpecification("Qlimax")
                .Or(new CodeStartsWithSpecification("Nothing"))
                .Or(new ItemBigIdSpecification());

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("CodeStartsWithSpecification Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "ItemBigIdSpecification+Failed", result.Trace);
        }

        [Fact]
        public void MultipleOrSpecificationsIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var sut = new CodeStartsWithSpecification("Qlimax")
                .Or(new CodeStartsWithSpecification("Nothing"))
                .Or(new ItemBigIdSpecification());

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(3, result.FailedSpecificationsCount);
            Assert.Equal(3, result.FailedSpecifications.Count);
            Assert.Equal(typeof(CodeStartsWithSpecification), result.FailedSpecifications[0].SpecificationType);
            Assert.Equal(1, result.FailedSpecifications[0].Parameters.Count);
            Assert.Equal("Qlimax", result.FailedSpecifications[0].Parameters["Code"]);
            Assert.Equal(candidate, result.FailedSpecifications[0].Candidate);
            Assert.Equal(1, result.FailedSpecifications[0].Errors.Count);
            Assert.Equal("Item code [Defqon.1] is not starts by [Qlimax]", result.FailedSpecifications[0].Errors[0]);
            Assert.Equal(typeof(CodeStartsWithSpecification), result.FailedSpecifications[1].SpecificationType);
            Assert.Equal(1, result.FailedSpecifications[1].Parameters.Count);
            Assert.Equal("Nothing", result.FailedSpecifications[1].Parameters["Code"]);
            Assert.Equal(candidate, result.FailedSpecifications[1].Candidate);
            Assert.Equal(1, result.FailedSpecifications[1].Errors.Count);
            Assert.Equal("Item code [Defqon.1] is not starts by [Nothing]", result.FailedSpecifications[1].Errors[0]);
            Assert.Equal(typeof(ItemBigIdSpecification), result.FailedSpecifications[2].SpecificationType);
            Assert.Equal(0, result.FailedSpecifications[2].Parameters.Count);
            Assert.Equal(candidate, result.FailedSpecifications[2].Candidate);
            Assert.Equal(1, result.FailedSpecifications[2].Errors.Count);
            Assert.Equal("Item Id is lower than 100", result.FailedSpecifications[2].Errors[0]);
            Assert.Equal(3, result.Errors.Count);
            Assert.Equal("Item code [Defqon.1] is not starts by [Qlimax]", result.Errors[0]);
            Assert.Equal("Item code [Defqon.1] is not starts by [Nothing]", result.Errors[1]);
            Assert.Equal("Item Id is lower than 100", result.Errors[2]);
            Assert.False(result.OverallResult);
            Assert.Equal("CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "ItemBigIdSpecification+Failed", result.Trace);
        }

        [Fact]
        public void MultipleSpecificationsWithGroupCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 9,
                Code = "Qountdown",
                Name = "Put some grace in your face",
                IsArchival = true
            };
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"));

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(5, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("NotActiveItemsSpecification And " +
                         "(CodeStartsWithSpecification Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed) And " +
                         "NameContainsSpecification", result.Trace);
        }

        [Fact]
        public void MultipleSpecificationsWithGroupIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"));

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(5, result.TotalSpecificationsCount);
            Assert.Equal(2, result.FailedSpecificationsCount);
            Assert.Equal(2, result.FailedSpecifications.Count);
            Assert.Equal(typeof(ActiveItemsSpecification), result.FailedSpecifications[0].SpecificationType);
            Assert.Equal(0, result.FailedSpecifications[0].Parameters.Count);
            Assert.Equal(candidate, result.FailedSpecifications[0].Candidate);
            Assert.Equal(1, result.FailedSpecifications[0].Errors.Count);
            Assert.Equal("Item is not archival: [1]", result.FailedSpecifications[0].Errors[0]);
            Assert.Equal(typeof(NameContainsSpecification), result.FailedSpecifications[1].SpecificationType);
            Assert.Equal(1, result.FailedSpecifications[1].Parameters.Count);
            Assert.Equal("some grace", result.FailedSpecifications[1].Parameters["Filter"]);
            Assert.Equal(candidate, result.FailedSpecifications[1].Candidate);
            Assert.Equal(1, result.FailedSpecifications[1].Errors.Count);
            Assert.Equal("Item [Purple Tail] not contains: [some grace]", result.FailedSpecifications[1].Errors[0]);
            Assert.Equal(2, result.Errors.Count);
            Assert.Equal("Item is not archival: [1]", result.Errors[0]);
            Assert.Equal("Item [Purple Tail] not contains: [some grace]", result.Errors[1]);
            Assert.False(result.OverallResult);
            Assert.Equal("NotActiveItemsSpecification+Failed And " +
                         "(CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification) And " +
                         "NameContainsSpecification+Failed", result.Trace);
        }

        [Fact]
        public void MultipleSpecificationsWithGroupNegationCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 4, Code = "In Qontrol", Name = "The Last City On Earth", IsArchival = true};
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications.Not())
                .And(new NameContainsSpecification("City On Earth"));

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(5, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("NotActiveItemsSpecification And " +
                         "Not(CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed) And " +
                         "NameContainsSpecification", result.Trace);
        }

        [Fact]
        public void MultipleSpecificationsWithGroupNegationIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications.Not())
                .And(new NameContainsSpecification("City On Earth"));

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(5, result.TotalSpecificationsCount);
            Assert.Equal(2, result.FailedSpecificationsCount);
            Assert.Equal(2, result.FailedSpecifications.Count);
            Assert.Equal(typeof(ActiveItemsSpecification), result.FailedSpecifications[0].SpecificationType);
            Assert.Equal(0, result.FailedSpecifications[0].Parameters.Count);
            Assert.Equal(candidate, result.FailedSpecifications[0].Candidate);
            Assert.Equal(1, result.FailedSpecifications[0].Errors.Count);
            Assert.Equal("Item is not archival: [1]", result.FailedSpecifications[0].Errors[0]);
            Assert.Equal(typeof(NameContainsSpecification), result.FailedSpecifications[1].SpecificationType);
            Assert.Equal(1, result.FailedSpecifications[1].Parameters.Count);
            Assert.Equal("City On Earth", result.FailedSpecifications[1].Parameters["Filter"]);
            Assert.Equal(candidate, result.FailedSpecifications[1].Candidate);
            Assert.Equal(1, result.FailedSpecifications[1].Errors.Count);
            Assert.Equal("Item [Purple Tail] not contains: [City On Earth]", result.FailedSpecifications[1].Errors[0]);
            Assert.Equal(2, result.Errors.Count);
            Assert.Equal("Item is not archival: [1]", result.Errors[0]);
            Assert.Equal("Item [Purple Tail] not contains: [City On Earth]", result.Errors[1]);
            Assert.False(result.OverallResult);
            Assert.Equal("NotActiveItemsSpecification+Failed And " +
                         "Not(CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification) And " +
                         "NameContainsSpecification+Failed", result.Trace);
        }

        [Fact]
        public void MultipleSpecificationsWIthNotLinqSpecificationCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 100,
                Code = "Sensation Black",
                Name = "We interrupt this program to bring you important news",
                IsArchival = true
            };
            var sut = new FavoriteItemSpecification()
                .Not()
                .And(new ActiveItemsSpecification().Not())
                .And(new ItemBigIdSpecification());

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("NotFavoriteItemSpecification And " +
                         "NotActiveItemsSpecification And " +
                         "ItemBigIdSpecification", result.Trace);
        }

        [Fact]
        public void MultipleSpecificationsWIthNotLinqSpecificationIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var sut = new FavoriteItemSpecification()
                .Not()
                .And(new ActiveItemsSpecification().Not())
                .And(new ItemBigIdSpecification());

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(3, result.FailedSpecificationsCount);
            Assert.Equal(3, result.FailedSpecifications.Count);
            Assert.Equal(typeof(FavoriteItemSpecification), result.FailedSpecifications[0].SpecificationType);
            Assert.Equal(0, result.FailedSpecifications[0].Parameters.Count);
            Assert.Equal(candidate, result.FailedSpecifications[0].Candidate);
            Assert.Equal(1, result.FailedSpecifications[0].Errors.Count);
            Assert.Equal("Specification [FavoriteItemSpecification] is satisfied by candidate",
                result.FailedSpecifications[0].Errors[0]);
            Assert.Equal(typeof(ActiveItemsSpecification), result.FailedSpecifications[1].SpecificationType);
            Assert.Equal(0, result.FailedSpecifications[1].Parameters.Count);
            Assert.Equal(candidate, result.FailedSpecifications[1].Candidate);
            Assert.Equal(1, result.FailedSpecifications[1].Errors.Count);
            Assert.Equal("Item is not archival: [1]", result.FailedSpecifications[1].Errors[0]);
            Assert.Equal(typeof(ItemBigIdSpecification), result.FailedSpecifications[2].SpecificationType);
            Assert.Equal(0, result.FailedSpecifications[2].Parameters.Count);
            Assert.Equal(candidate, result.FailedSpecifications[2].Candidate);
            Assert.Equal(1, result.FailedSpecifications[2].Errors.Count);
            Assert.Equal("Item Id is lower than 100", result.FailedSpecifications[2].Errors[0]);
            Assert.Equal(3, result.Errors.Count);
            Assert.Equal("Specification [FavoriteItemSpecification] is satisfied by candidate", result.Errors[0]);
            Assert.Equal("Item is not archival: [1]", result.Errors[1]);
            Assert.Equal("Item Id is lower than 100", result.Errors[2]);
            Assert.False(result.OverallResult);
            Assert.Equal("NotFavoriteItemSpecification+Failed And " +
                         "NotActiveItemsSpecification+Failed And " +
                         "ItemBigIdSpecification+Failed", result.Trace);
        }

        [Fact]
        public void NegationMultipleDifferentSpecificationsCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 5,
                Code = "Defqon.1 Australia",
                Name = "All aboard, this is easy for real",
                IsArchival = false
            };
            var sut = new ItemBigIdSpecification()
                .Or(new ActiveItemsSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not())
                .Not();

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(4, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.False(result.OverallResult);
            Assert.Equal("Not(ItemBigIdSpecification+Failed Or " +
                         "ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NotNameContainsSpecification)", result.Trace);
        }

        [Fact]
        public void NegationMultipleDifferentSpecificationsIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var sut = new ItemBigIdSpecification()
                .Or(new ActiveItemsSpecification())
                .And(new CodeStartsWithSpecification("Defqon"))
                .And(new NameContainsSpecification("Purple Tail").Not())
                .Not();

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(4, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("Not(ItemBigIdSpecification+Failed Or " +
                         "ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NotNameContainsSpecification+Failed)", result.Trace);
        }

        [Fact]
        public void NegationMultipleSpecificationsCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 5,
                Code = "Defqon.1 Australia",
                Name = "All aboard, this is easy for real",
                IsArchival = false
            };
            var sut = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"))
                .Not();

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.False(result.OverallResult);
            Assert.Equal("Not(ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NameContainsSpecification)", result.Trace);
        }

        [Fact]
        public void NegationMultipleSpecificationsIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var sut = new ActiveItemsSpecification()
                .And(new CodeStartsWithSpecification("Defqon.1"))
                .And(new NameContainsSpecification("easy"))
                .Not();

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(3, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("Not(ActiveItemsSpecification And " +
                         "CodeStartsWithSpecification And " +
                         "NameContainsSpecification+Failed)", result.Trace);
        }

        [Fact]
        public void NegationMultipleSpecificationsWithGroupCorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event
            {
                Id = 9,
                Code = "Qountdown",
                Name = "Put some grace in your face",
                IsArchival = true
            };
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"))
                .Not();

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.False(overall);
            Assert.Equal(5, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.False(result.OverallResult);
            Assert.Equal("Not(NotActiveItemsSpecification And " +
                         "(CodeStartsWithSpecification Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed) And " +
                         "NameContainsSpecification)", result.Trace);
        }

        [Fact]
        public void NegationMultipleSpecificationsWithGroupIncorrectCandidate_ReturnExpectedResultObject()
        {
            var candidate = new Event {Id = 1, Code = "Defqon.1", Name = "Purple Tail", IsArchival = false};
            var notActiveItems = new ActiveItemsSpecification()
                .Not();
            var codeSpecifications = new CodeStartsWithSpecification("Qountdown")
                .Or(new CodeStartsWithSpecification("Hard"))
                .Or(new CodeStartsWithSpecification("Defqon.1"));
            var sut = notActiveItems
                .And(codeSpecifications)
                .And(new NameContainsSpecification("some grace"))
                .Not();

            var overall = sut.IsSatisfiedBy(candidate, out var result);

            Assert.True(overall);
            Assert.Equal(5, result.TotalSpecificationsCount);
            Assert.Equal(0, result.FailedSpecificationsCount);
            Assert.Equal(0, result.FailedSpecifications.Count);
            Assert.Equal(0, result.Errors.Count);
            Assert.True(result.OverallResult);
            Assert.Equal("Not(NotActiveItemsSpecification+Failed And " +
                         "(CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification+Failed Or " +
                         "CodeStartsWithSpecification) And " +
                         "NameContainsSpecification+Failed)", result.Trace);
        }
    }
}