using FluentSpecification.Core;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeOrNot_ReturnOrSpecification()
        {
            var left = MockComplexSpecification.True();
            var right = MockComplexSpecification.True();
            var expected = new OrSpecification<object>(left, right.Not());

            var sut = Specification.OrNot(left, right);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeOrNotProperty_ReturnPropertySpecification()
        {
            var left = MockComplexSpecification<int>.True();
            var right = MockComplexSpecification<int>.True();
            var expected = new PropertySpecification<FakeType, int>(
                ft => ft.First, new OrSpecification<int>(left, right.Not()));

            var sut = Specification.OrNot<FakeType, int>(
                ft => ft.First, left, right);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}