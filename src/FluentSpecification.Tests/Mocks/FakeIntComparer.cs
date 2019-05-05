using System.Collections.Generic;

namespace FluentSpecification.Tests.Mocks
{
    internal class FakeIntComparer : IComparer<int>, IEqualityComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }

        public bool Equals(int x, int y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(int obj)
        {
            return obj.GetHashCode();
        }
    }
}