using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeNotMaxLength_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new MaxLengthSpecification<string>(0, true));

            var sut = new MockCompositeSpecification<string>().NotMaxLength(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeNotMaxLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new MaxLengthSpecification<string>(0, true)));

            var sut = new MockCompositeSpecification<FakeType>().NotMaxLength(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotMaxLength_ReturnNotSpecification()
        {
            var expected = new NotSpecification<string>(
                new MaxLengthSpecification<string>(0, true));

            var sut = Specification.NotMaxLength<string>(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeNotMaxLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new NotSpecification<string>(
                    new MaxLengthSpecification<string>(0, true)));

            var sut = Specification.NotMaxLength<FakeType, string>(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}