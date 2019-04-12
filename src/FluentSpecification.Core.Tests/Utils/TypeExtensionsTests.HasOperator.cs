using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Data;
using FluentSpecification.Core.Utils;
using FluentSpecification.Tests.Sdk;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    [UsedImplicitly]
    public partial class TypeExtensionsTests
    {
        public class HasEqualityOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnFalse(Type sut)
            {
                var result = sut.HasEqualityOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasEqualityOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnTrue(Type sut)
            {
                var result = sut.HasEqualityOperator();

                Assert.True(result);
            }
        }

        public class HasInequalityOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnFalse(Type sut)
            {
                var result = sut.HasInequalityOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasInequalityOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnTrue(Type sut)
            {
                var result = sut.HasInequalityOperator();

                Assert.True(result);
            }
        }

        public class HasLessThanOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnFalse(Type sut)
            {
                var result = sut.HasLessThanOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasLessThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnTrue(Type sut)
            {
                var result = sut.HasLessThanOperator();

                Assert.True(result);
            }
        }

        public class HasLessThanOrEqualOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnFalse(Type sut)
            {
                var result = sut.HasLessThanOrEqualOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasLessThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnTrue(Type sut)
            {
                var result = sut.HasLessThanOrEqualOperator();

                Assert.True(result);
            }
        }

        public class HasGreaterThanOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnFalse(Type sut)
            {
                var result = sut.HasGreaterThanOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasGreaterThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnTrue(Type sut)
            {
                var result = sut.HasGreaterThanOperator();

                Assert.True(result);
            }
        }

        public class HasGreaterThanOrEqualOperator
        {
            [Theory]
            [IncorrectData(typeof(TypeComparableData))]
            public void InvalidType_ReturnFalse(Type sut)
            {
                var result = sut.HasGreaterThanOrEqualOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasGreaterThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<ArgumentNullException>(exception);
            }

            [Theory]
            [CorrectData(typeof(TypeComparableData))]
            public void ValidType_ReturnTrue(Type sut)
            {
                var result = sut.HasGreaterThanOrEqualOperator();

                Assert.True(result);
            }
        }
    }
}