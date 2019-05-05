using System;

namespace FluentSpecification.Tests.Mocks
{
    public class ComparableFakeType : FakeType,
        IComparable<ComparableFakeType>
    {
        public int CompareTo(ComparableFakeType other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return First.CompareTo(other.First);
        }
    }
}