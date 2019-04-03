using System;
using System.Diagnostics.CodeAnalysis;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;
using Xunit;

namespace FluentSpecification.Core.Tests.Utils
{
    [UsedImplicitly]
    public partial class TypeExtensionsTests
    {
        public class HasEqualityOperator
        {
            [Fact]
            public void InvalidType_ReturnFalse()
            {
                var sut = typeof(FakeType);

                var result = sut.HasEqualityOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasEqualityOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnTrue()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.HasEqualityOperator();

                Assert.True(result);
            }
        }

        public class HasInequalityOperator
        {
            [Fact]
            public void InvalidType_ReturnFalse()
            {
                var sut = typeof(FakeType);

                var result = sut.HasInequalityOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasInequalityOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnTrue()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.HasInequalityOperator();

                Assert.True(result);
            }
        }

        public class HasLessThanOperator
        {
            [Fact]
            public void InvalidType_ReturnFalse()
            {
                var sut = typeof(FakeType);

                var result = sut.HasLessThanOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasLessThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnTrue()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.HasLessThanOperator();

                Assert.True(result);
            }
        }

        public class HasLessThanOrEqualOperator
        {
            [Fact]
            public void InvalidType_ReturnFalse()
            {
                var sut = typeof(FakeType);

                var result = sut.HasLessThanOrEqualOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasLessThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnTrue()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.HasLessThanOrEqualOperator();

                Assert.True(result);
            }
        }

        public class HasGreaterThanOperator
        {
            [Fact]
            public void InvalidType_ReturnFalse()
            {
                var sut = typeof(FakeType);

                var result = sut.HasGreaterThanOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasGreaterThanOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnTrue()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.HasGreaterThanOperator();

                Assert.True(result);
            }
        }

        public class HasGreaterThanOrEqualOperator
        {
            [Fact]
            public void InvalidType_ReturnFalse()
            {
                var sut = typeof(FakeType);

                var result = sut.HasGreaterThanOrEqualOperator();

                Assert.False(result);
            }

            [Fact]
            [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
            public void NullType_Exception()
            {
                var exception = Record.Exception(() => ((Type) null).HasGreaterThanOrEqualOperator());

                Assert.NotNull(exception);
                Assert.IsType<NullReferenceException>(exception);
            }

            [Fact]
            public void ValidType_ReturnTrue()
            {
                var sut = typeof(ComparableFakeType);

                var result = sut.HasGreaterThanOrEqualOperator();

                Assert.True(result);
            }
        }
    }
}