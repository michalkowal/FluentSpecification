using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeLength_ReturnLengthSpecification()
        {
            var expected = new LengthSpecification<string>(0, true);

            var sut = new MockCompositeSpecification<string>().Length(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new LengthSpecification<string>(0, true));

            var sut = new MockCompositeSpecification<FakeType>().Length(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLength_ReturnLengthSpecification()
        {
            var expected = new LengthSpecification<FakeType>(0, true);

            var sut = Specification.Length<FakeType>(0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeLengthProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new LengthSpecification<string>(0, true));

            var sut = Specification.Length<FakeType, string>(
                ft => ft.Second, 0);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}