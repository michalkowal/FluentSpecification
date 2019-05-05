using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeCreditCard_ReturnCreditCardSpecification()
        {
            var expected = new CreditCardSpecification();

            var sut = new MockCompositeSpecification<string>().CreditCard();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeCreditCardProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new CreditCardSpecification());

            var sut = new MockCompositeSpecification<FakeType>().CreditCard(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCreditCard_ReturnCreditCardSpecification()
        {
            var expected = new CreditCardSpecification();

            var sut = Specification.CreditCard();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCreditCardProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new CreditCardSpecification());

            var sut = Specification.CreditCard<FakeType>(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}