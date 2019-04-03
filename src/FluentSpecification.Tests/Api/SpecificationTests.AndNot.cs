using FluentSpecification.Core;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeAndNot_ReturnAndSpecification()
        {
            var left = MockComplexSpecification.True();
            var right = MockComplexSpecification.True();
            var expected = new AndSpecification<object>(left, right.Not());

            var sut = Specification.AndNot(left, right);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeAndNotProperty_ReturnPropertySpecification()
        {
            var left = MockComplexSpecification<int>.True();
            var right = MockComplexSpecification<int>.True();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new AndSpecification<int>(left, right.Not()));

            var sut = Specification.AndNot<FakeType, int>(
                ft => ft.First, left, right);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}