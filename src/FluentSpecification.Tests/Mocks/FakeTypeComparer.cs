using System.Collections;
using System.Collections.Generic;

namespace FluentSpecification.Tests.Mocks
{
    internal class FakeTypeComparer :
        IEqualityComparer, IEqualityComparer<FakeType>,
        IComparer, IComparer<FakeType>
    {
        public int Compare(object x, object y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;

            if (!(y is FakeType))
                return 1;
            if (!(x is FakeType))
                return -1;

            return Compare((FakeType) x, (FakeType) y);
        }

        public int Compare(FakeType x, FakeType y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.First.CompareTo(y.First);
        }

        public new bool Equals(object x, object y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(null, y)) return false;
            if (ReferenceEquals(null, x)) return false;
            return x is EquatableFakeType current && y is EquatableFakeType other && Equals(current, other);
        }

        public int GetHashCode(object obj)
        {
            if (obj is EquatableFakeType fake)
                return GetHashCode(fake);
            return obj.GetHashCode();
        }

        public bool Equals(FakeType x, FakeType y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(null, y)) return false;
            if (ReferenceEquals(null, x)) return false;
            return x.First == y.First;
        }

        public int GetHashCode(FakeType obj)
        {
            return obj.First.GetHashCode();
        }
    }
}