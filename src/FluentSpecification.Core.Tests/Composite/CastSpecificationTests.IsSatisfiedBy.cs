using System.Collections.Generic;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk;
using Xunit;

namespace FluentSpecification.Core.Tests.Composite
{
    public partial class CastSpecificationTests
    {
        public class IsSatisfiedBy
        {
            [Fact]
            public void CastFromBaseType_ReturnTrue()
            {
                FakeType candidate = new ChildFakeType();
                var specification = MockSpecification<ChildFakeType>.True();
                var sut = new CastSpecification<FakeType, ChildFakeType>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void CastFromInterfaceType_ReturnTrue()
            {
                IEnumerable<char> candidate = new FakeType();
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<IEnumerable<char>, FakeType>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void CastFromObject_ReturnTrue()
            {
                var candidate = 0;
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<int, object>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void CastToBaseType_ReturnTrue()
            {
                var candidate = new ChildFakeType();
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<ChildFakeType, FakeType>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void CastToInterfaceType_ReturnTrue()
            {
                var candidate = new FakeType();
                var specification = MockSpecification<IEnumerable<char>>.True();
                var sut = new CastSpecification<FakeType, IEnumerable<char>>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void CastToObject_ReturnTrue()
            {
                var candidate = 0;
                var specification = MockSpecification<object>.True();
                var sut = new CastSpecification<int, object>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void CastNumeric_ReturnTrue()
            {
                var candidate = 0.0;
                var specification = MockSpecification<int>.True();
                var sut = new CastSpecification<double, int>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.True(result);
            }

            [Fact]
            public void FalseSpecification_ReturnFalse()
            {
                var candidate = 0;
                var specification = MockSpecification<object>.False();
                var sut = new CastSpecification<int, object>(specification);

                var result = sut.IsSatisfiedBy(candidate);

                Assert.False(result);
            }

            [Fact]
            public void InvalidTypeCandidate_ReturnFalse()
            {
                var specification = MockSpecification<List<int>>.True();
                var sut = new CastSpecification<IEnumerable<int>, List<int>>(specification);

                var result = sut.IsSatisfiedBy(new int[0]);

                Assert.False(result);
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<object, FakeType>(specification);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null));

                Assert.Null(exception);
            }
        }

        public class IsSatisfiedBySpecificationResult
        {
            [Fact]
            public void CastFromBaseType_ReturnExpectedResultObject()
            {
                FakeType candidate = new ChildFakeType();
                var specification = MockComplexSpecification<ChildFakeType>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<FakeType,ChildFakeType>(TrueMockComplexSpecification[ChildFakeType])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<FakeType, ChildFakeType>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<ChildFakeType>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, candidate));
                var sut = new CastSpecification<FakeType, ChildFakeType>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void CastFromInterfaceType_ReturnExpectedResultObject()
            {
                IEnumerable<char> candidate = new FakeType();
                var specification = MockComplexSpecification<FakeType>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<IEnumerable<Char>,FakeType>(TrueMockComplexSpecification[FakeType])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<IEnumerable<char>, FakeType>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<FakeType>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, candidate));
                var sut = new CastSpecification<IEnumerable<char>, FakeType>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void CastFromObject_ReturnExpectedResultObject()
            {
                var candidate = 0;
                var specification = MockComplexSpecification<object>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<Int32,Object>(TrueMockComplexSpecification[Object])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<int, object>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<object>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, candidate));
                var sut = new CastSpecification<int, object>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void CastToBaseType_ReturnExpectedResultObject()
            {
                var candidate = new ChildFakeType();
                var specification = MockComplexSpecification<FakeType>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<ChildFakeType,FakeType>(TrueMockComplexSpecification[FakeType])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<ChildFakeType, FakeType>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<FakeType>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, candidate));
                var sut = new CastSpecification<ChildFakeType, FakeType>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void CastToInterfaceType_ReturnExpectedResultObject()
            {
                var candidate = new FakeType();
                var specification = MockComplexSpecification<IEnumerable<char>>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<FakeType,IEnumerable<Char>>(TrueMockComplexSpecification[IEnumerable`1])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<FakeType, IEnumerable<char>>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<IEnumerable<char>>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, candidate));
                var sut = new CastSpecification<FakeType, IEnumerable<char>>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void CastToObject_ReturnExpectedResultObject()
            {
                var candidate = 0;
                var specification = MockComplexSpecification<object>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<Int32,Object>(TrueMockComplexSpecification[Object])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<int, object>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<object>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, candidate));
                var sut = new CastSpecification<int, object>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void CastNumeric_ReturnTrue()
            {
                var candidate = 0.0;
                var specification = MockComplexSpecification<int>.True();
                var expected = new SpecificationResult(true,
                    new SpecificationTrace(
                        "CastSpecification<Double,Int32>(TrueMockComplexSpecification[Int32])",
                        "Cast(TrueMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<double, int>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(true, typeof(TrueMockComplexSpecification<int>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", true }
                        }, 0));
                var sut = new CastSpecification<double, int>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.True(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void FalseSpecification_ReturnExpectedResultObject()
            {
                var candidate = 0;
                var specification = MockComplexSpecification<object>.False();
                var expected = new SpecificationResult(false,
                    new SpecificationTrace("CastSpecification<Int32,Object>(FailedFalseMockComplexSpecification[Object])",
                        "Cast(FailedFalseMockComplex)"),
                    new SpecificationInfo(true, typeof(CastSpecification<int, object>), false,
                        new Dictionary<string, object>
                        {
                            { "Specification", specification }
                        }, candidate),
                    new SpecificationInfo(false, typeof(FalseMockComplexSpecification<object>), false,
                        new Dictionary<string, object>
                        {
                            { "Result", false }
                        }, candidate, "MockValidationSpecification is not satisfied"));
                var sut = new CastSpecification<int, object>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void InvalidTypeCandidate_ReturnExpectedResultObject()
            {
                IEnumerable<int> candidate = new int[0];
                ISpecification<List<int>> specification = MockComplexSpecification<List<int>>.True();
                var expected = new SpecificationResult(false,
                    new SpecificationTrace("CastSpecification<IEnumerable<Int32>,List<Int32>>()+Failed",
                        "Cast()+Failed"),
                    new SpecificationInfo(false, typeof(CastSpecification<IEnumerable<int>, List<int>>), false,
                        new Dictionary<string, object>
                        {
                            {"Specification", specification}
                        }, candidate, "Cannot cast type [Int32[]] to [List<Int32>]"));
                var sut = new CastSpecification<IEnumerable<int>, List<int>>(specification);

                var overall = sut.IsSatisfiedBy(candidate, out var result);

                Assert.False(overall);
                Assert.Equal(expected, result, new SpecificationResultComparer());
            }

            [Fact]
            public void NullCandidate_NoException()
            {
                var specification = MockSpecification<FakeType>.True();
                var sut = new CastSpecification<object, FakeType>(specification);

                var exception = Record.Exception(() => sut.IsSatisfiedBy(null, out _));

                Assert.Null(exception);
            }
        }
    }
}