using System;

namespace FluentSpecification.Tests.Mocks
{
    public class ComparableInterFakeType : InterFakeType,
        IComparable
    {
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            if (obj is ComparableInterFakeType other)
                return Third.CompareTo(other.Third);
            return 1;
        }
    }
}