using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotMinLength_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new MinLengthSpecification<string>(0, true));

            var sut = new MockCompositeSpecification<string>().NotMinLength(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotMinLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new MinLengthSpecification<string>(0, true)));

            var sut = new MockCompositeSpecification<FakeType>().NotMinLength(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotMinLength_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new MinLengthSpecification<string>(0, true));

            var sut = Specification.NotMinLength<string>(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotMinLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new MinLengthSpecification<string>(0, true)));

            var sut = Specification.NotMinLength<FakeType, string>(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}