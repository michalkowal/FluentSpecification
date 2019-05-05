using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeIsType_ReturnIsTypeSpecification()
        {
            var expected = new IsTypeSpecification<int>(typeof(FakeType));

            var sut = new MockCompositeSpecification<int>().IsType(typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeIsTypeProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new IsTypeSpecification<int>(typeof(FakeType)));

            var sut = new MockCompositeSpecification<FakeType>().IsType(
                ft => ft.First, typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeIsType_ReturnIsTypeSpecification()
        {
            var expected = new IsTypeSpecification<FakeType>(typeof(FakeType));

            var sut = Specification.IsType<FakeType>(typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeIsTypeProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new IsTypeSpecification<int>(typeof(FakeType)));

            var sut = Specification.IsType<FakeType, int>(
                ft => ft.First, typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}