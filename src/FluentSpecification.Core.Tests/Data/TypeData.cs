using System;
using System.Collections;
using System.Collections.Generic;
using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Core.Tests.Data
{
    public class TypeNumericData : BaseData
    {
        public TypeNumericData()
        {
            AddValid(typeof(byte));
            AddValid(typeof(sbyte));
            AddValid(typeof(ushort));
            AddValid(typeof(uint));
            AddValid(typeof(ulong));
            AddValid(typeof(short));
            AddValid(typeof(int));
            AddValid(typeof(long));
            AddValid(typeof(double));
            AddValid(typeof(decimal));
            AddValid(typeof(float));
            AddValid(typeof(byte?));
            AddValid(typeof(sbyte?));
            AddValid(typeof(ushort?));
            AddValid(typeof(uint?));
            AddValid(typeof(ulong?));
            AddValid(typeof(short?));
            AddValid(typeof(int?));
            AddValid(typeof(long?));
            AddValid(typeof(double?));
            AddValid(typeof(decimal?));
            AddValid(typeof(float?));
            
            AddInvalid(typeof(string));
            AddInvalid(typeof(FakeType));
            AddInvalid(typeof(ChildComparableFakeType));
            AddInvalid(typeof(KeyValuePair<string, int>));
            AddInvalid(typeof(KeyValuePair<string, int>?));
        }
    }

    public class TypeIsEnumerableData : BaseData
    {
        public TypeIsEnumerableData()
        {
            AddValid(typeof(FakeType));
            AddValid(typeof(ChildFakeType));
            AddValid(typeof(string[]));
            AddValid(typeof(string));
            AddValid(typeof(List<int>));
            AddValid(typeof(Dictionary<string, bool>));
            AddValid(typeof(IReadOnlyCollection<int>));
            AddValid(typeof(IEnumerable<int>));

            AddInvalid(typeof(int));
            AddInvalid(typeof(object));
            AddInvalid(typeof(IComparable));
            AddInvalid(typeof(InterFakeType));
            AddInvalid(typeof(IEnumerable));
        }
    }

    public class TypeEnumerableAttributeData : BaseData
    {
        public TypeEnumerableAttributeData()
        {
            AddValid(typeof(FakeType), typeof(char));
            AddValid(typeof(ChildFakeType), typeof(char));
            AddValid(typeof(string[]), typeof(string));
            AddValid(typeof(string), typeof(char));
            AddValid(typeof(List<int>), typeof(int));
            AddValid(typeof(Dictionary<string, bool>), typeof(KeyValuePair<string, bool>));
            AddValid(typeof(IReadOnlyCollection<int>), typeof(int));
            AddValid(typeof(IEnumerable<int>), typeof(int));
        }
    }

    public class TypeComparableData : BaseData
    {
        public TypeComparableData()
        {
            AddValid(typeof(ComparableFakeType));
            AddValid(typeof(ChildComparableFakeType));

            AddInvalid(typeof(FakeType));
            AddInvalid(typeof(ChildFakeType));
        }
    }
}