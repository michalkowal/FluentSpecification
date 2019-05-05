using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotEmail_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new EmailSpecification());

            var sut = new MockCompositeSpecification<string>().NotEmail();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotEmailProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new EmailSpecification()));

            var sut = new MockCompositeSpecification<FakeType>().NotEmail(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotEmail_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new EmailSpecification());

            var sut = Specification.NotEmail();

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotEmailProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new EmailSpecification()));

            var sut = Specification.NotEmail<FakeType>(
                ft => ft.Second);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}