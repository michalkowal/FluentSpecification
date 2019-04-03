using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Api
{
    [UsedImplicitly]
    public class FluentProxyTests
    {
        public class AndProxy
        {
            [Fact]
            public void Compose_ReturnAndSpecification()
            {
                var sut = new AndFluentProxy<object>(MockSpecification.True());
                var result = sut.Compose(MockSpecification.True());

                Assert.NotNull(result);
                Assert.IsType<AndSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => new AndFluentProxy<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class AndNotProxy
        {
            [Fact]
            public void Compose_ReturnAndSpecification()
            {
                var sut = new AndNotFluentProxy<object>(MockSpecification.True());
                var result = sut.Compose(MockSpecification.True());

                Assert.NotNull(result);
                Assert.IsType<AndSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void Compose_ReturnAndWithNegatedRight()
            {
                var sut = new AndNotFluentProxy<object>(MockSpecification.True());
                var andNot = sut.Compose(MockSpecification.True());

                var fieldInfo = andNot.GetType().BaseType
                    .GetField("_right", BindingFlags.Instance | BindingFlags.NonPublic);
                var result = fieldInfo.GetValue(andNot);

                Assert.NotNull(result);
                Assert.IsType<NotSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => new AndNotFluentProxy<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class OrProxy
        {
            [Fact]
            public void Compose_ReturnOrSpecification()
            {
                var sut = new OrFluentProxy<object>(MockSpecification.True());
                var result = sut.Compose(MockSpecification.True());

                Assert.NotNull(result);
                Assert.IsType<OrSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => new OrFluentProxy<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class OrNotProxy
        {
            [Fact]
            public void Compose_ReturnOrSpecification()
            {
                var sut = new OrNotFluentProxy<object>(MockSpecification.True());
                var result = sut.Compose(MockSpecification.True());

                Assert.NotNull(result);
                Assert.IsType<OrSpecification<object>>(result);
            }

            [Fact]
            public void Compose_ReturnOrWithNegatedRight()
            {
                var sut = new OrNotFluentProxy<object>(MockSpecification.True());
                var orNot = sut.Compose(MockSpecification.True());

                var fieldInfo = orNot.GetType().BaseType
                    .GetField("_right", BindingFlags.Instance | BindingFlags.NonPublic);
                var result = fieldInfo.GetValue(orNot);

                Assert.NotNull(result);
                Assert.IsType<NotSpecification<object>>(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelfSpecification_ArgumentNullException()
            {
                var exception = Record.Exception(() => new OrNotFluentProxy<object>(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}