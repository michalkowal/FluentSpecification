using System;
using System.Collections;
using System.Collections.Generic;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class TypeNumericData : SpecificationData<Type>
    {
        public TypeNumericData()
        {
            Valid(typeof(byte));
            Valid(typeof(sbyte));
            Valid(typeof(ushort));
            Valid(typeof(uint));
            Valid(typeof(ulong));
            Valid(typeof(short));
            Valid(typeof(int));
            Valid(typeof(long));
            Valid(typeof(double));
            Valid(typeof(decimal));
            Valid(typeof(float));
            Valid(typeof(byte?));
            Valid(typeof(sbyte?));
            Valid(typeof(ushort?));
            Valid(typeof(uint?));
            Valid(typeof(ulong?));
            Valid(typeof(short?));
            Valid(typeof(int?));
            Valid(typeof(long?));
            Valid(typeof(double?));
            Valid(typeof(decimal?));
            Valid(typeof(float?));

            Invalid(typeof(string));
            Invalid(typeof(FakeType));
            Invalid(typeof(ChildComparableFakeType));
            Invalid(typeof(KeyValuePair<string, int>));
            Invalid(typeof(KeyValuePair<string, int>?));
        }
    }

    public class TypeIsEnumerableData : SpecificationData<Type>
    {
        public TypeIsEnumerableData()
        {
            Valid(typeof(FakeType));
            Valid(typeof(ChildFakeType));
            Valid(typeof(string[]));
            Valid(typeof(string));
            Valid(typeof(List<int>));
            Valid(typeof(Dictionary<string, bool>));
            Valid(typeof(IReadOnlyCollection<int>));
            Valid(typeof(IEnumerable<int>));

            Invalid(typeof(int));
            Invalid(typeof(object));
            Invalid(typeof(IComparable));
            Invalid(typeof(InterFakeType));
            Invalid(typeof(IEnumerable));
        }
    }

    public class TypeEnumerableAttributeData : SpecificationData<Type, Type>
    {
        public TypeEnumerableAttributeData()
        {
            Valid(typeof(FakeType), typeof(char));
            Valid(typeof(ChildFakeType), typeof(char));
            Valid(typeof(string[]), typeof(string));
            Valid(typeof(string), typeof(char));
            Valid(typeof(List<int>), typeof(int));
            Valid(typeof(Dictionary<string, bool>), typeof(KeyValuePair<string, bool>));
            Valid(typeof(IReadOnlyCollection<int>), typeof(int));
            Valid(typeof(IEnumerable<int>), typeof(int));
        }
    }

    public class TypeComparableData : SpecificationData<Type>
    {
        public TypeComparableData()
        {
            Valid(typeof(ComparableFakeType));
            Valid(typeof(ChildComparableFakeType));

            Invalid(typeof(FakeType));
            Invalid(typeof(ChildFakeType));
        }
    }
}