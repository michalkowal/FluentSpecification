using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    public partial class TypeExtensionsTests
    {
        public class GetEqualsMethod
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetEqualsMethod(typeof(FakeType));

                Assert.Null(result);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetEqualsMethod(typeof(ComparableFakeType));

                Assert.NotNull(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualsMethod(typeof(FakeType)));

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
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
        }

        public class GetGenericEqualsMethod
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnNull(Type sut)
            {
                var result = sut.GetEqualsMethod<FakeType>();

                Assert.Null(result);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetEqualsMethod<ComparableFakeType>();

                Assert.NotNull(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualsMethod<FakeType>());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }

        public class GetBaseEqualsMethod
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnBaseMethodInfo(Type sut)
            {
                var result = sut.GetEqualsMethod();

                Assert.NotNull(result);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnMethodInfo(Type sut)
            {
                var result = sut.GetEqualsMethod();

                Assert.NotNull(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullSelf_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).GetEqualsMethod());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }
        }
    }
}