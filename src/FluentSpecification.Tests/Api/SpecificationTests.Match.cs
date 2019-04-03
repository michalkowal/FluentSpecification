using System.Text.RegularExpressions;
using FluentSpecification.Common;
using FluentSpecification.Core.Composite;
using FluentSpecification.Tests.Mocks;
using Xunit;

namespace FluentSpecification.Tests.Api
{
    public partial class SpecificationTests
    {
        [Fact]
        public void InvokeCompositeMatch_ReturnMatchSpecification()
        {
            var expected = new MatchSpecification("pattern", RegexOptions.IgnoreCase);

            var sut = new MockCompositeSpecification<string>().Match("pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeCompositeMatchProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new MatchSpecification("pattern", RegexOptions.IgnoreCase));

            var sut = new MockCompositeSpecification<FakeType>().Match(
                ft => ft.Second, "pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeMatch_ReturnMatchSpecification()
        {
            var expected = new MatchSpecification("pattern", RegexOptions.IgnoreCase);

            var sut = Specification.Match("pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }

        [Fact]
        public void InvokeMatchProperty_ReturnPropertySpecification()
        {
            var expected = new PropertySpecification<FakeType, string>(
                ft => ft.Second, new MatchSpecification("pattern", RegexOptions.IgnoreCase));

            var sut = Specification.Match<FakeType>(
                ft => ft.Second, "pattern", RegexOptions.IgnoreCase);

            Assert.Equal(expected, sut, new SpecificationComparer());
        }
    }
}