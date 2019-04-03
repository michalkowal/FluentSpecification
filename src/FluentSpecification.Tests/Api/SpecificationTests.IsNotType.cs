using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeIsNotType_ReturnNotSpecification()
        {
            var expected = new NotSpecification<int>(
                new IsTypeSpecification<int>(typeof(FakeType)));

            var sut = new MockCompositeSpecification<int>().IsNotType(typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeIsNotTypeProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new IsTypeSpecification<int>(typeof(FakeType))));

            var sut = new MockCompositeSpecification<FakeType>().IsNotType(
                ft => ft.First, typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeIsNotType_ReturnNotSpecification()
        {
            var expected = new NotSpecification<int>(
                new IsTypeSpecification<int>(typeof(FakeType)));

            var sut = Specification.IsNotType<int>(typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeIsNotTypeProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new NotSpecification<int>(
                    new IsTypeSpecification<int>(typeof(FakeType))));

            var sut = Specification.IsNotType<FakeType, int>(
                ft => ft.First, typeof(FakeType));

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}