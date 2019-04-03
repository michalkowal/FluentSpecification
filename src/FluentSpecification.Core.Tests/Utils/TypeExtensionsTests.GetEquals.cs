using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class GetEqualsMethod
        {
            [Fact]
            public void InvalidType_ReturnBaseMethodInfo()
            {
                var sut = typeof(FakeType);

                var result = sut.GetEqualsMethod(typeof(FakeType));

                Assert.NotNull(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualsMethod(typeof(FakeType)));

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var sut = typeof(FakeType);

                var exception = Record.Exception(() => sut.GetEqualsMethod(null));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetEqualsMethod(typeof(ComparableFakeType));

                Assert.NotNull(result);
            }
        }

        public class GetGenericEqualsMethod
        {
            [Fact]
            public void InvalidType_ReturnBaseMethodInfo()
            {
                var sut = typeof(FakeType);

                var result = sut.GetEqualsMethod<FakeType>();

                Assert.NotNull(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualsMethod<FakeType>());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetEqualsMethod<ComparableFakeType>();

                Assert.NotNull(result);
            }
        }

        public class GetBaseEqualsMethod
        {
            [Fact]
            public void InvalidType_ReturnBaseMethodInfo()
            {
                var sut = typeof(FakeType);

                var result = sut.GetEqualsMethod();

                Assert.NotNull(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualsMethod());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnMethodInfo()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.GetEqualsMethod();

                Assert.NotNull(result);
            }
        }
    }
}