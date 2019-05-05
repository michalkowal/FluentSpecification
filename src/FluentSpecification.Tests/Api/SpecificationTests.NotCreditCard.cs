using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotCreditCard_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new CreditCardSpecification());

            var sut = new MockCompositeSpecification<string>().NotCreditCard();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotCreditCardProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new CreditCardSpecification()));

            var sut = new MockCompositeSpecification<FakeType>().NotCreditCard(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotCreditCard_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new CreditCardSpecification());

            var sut = Specification.NotCreditCard();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotCreditCardProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new CreditCardSpecification()));

            var sut = Specification.NotCreditCard<FakeType>(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}