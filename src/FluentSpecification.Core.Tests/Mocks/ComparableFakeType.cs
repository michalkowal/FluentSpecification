using System;
using System.Collections.Generic;

namespace FluentSpecification.Core.Tests.Mocks
{
    public class ComparableFakeType :
        IEquatable<ComparableFakeType>,
        IComparable<ComparableFakeType>,
        IComparable
    {
        private readonly int _id = 0;

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            return obj is ComparableFakeType other
                ? CompareTo(other)
                : throw new ArgumentException($"Object must be of type {nameof(ComparableFakeType)}");
        }

        public int CompareTo(ComparableFakeType other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return _id.CompareTo(other._id);
        }

        public bool Equals(ComparableFakeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _id == other._id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ComparableFakeType) obj);
        }

        public override int GetHashCode()
        {
            return _id;
        }

        public static bool operator ==(ComparableFakeType left, ComparableFakeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ComparableFakeType left, ComparableFakeType right)
        {
            return !Equals(left, right);
        }

        public static bool operator <(ComparableFakeType left, ComparableFakeType right)
        {
            return Comparer<ComparableFakeType>.Default.Compare(left, right) < 0;
        }

        public static bool operator >(ComparableFakeType left, ComparableFakeType right)
        {
            return Comparer<ComparableFakeType>.Default.Compare(left, right) > 0;
        }

        public static bool operator <=(ComparableFakeType left, ComparableFakeType right)
        {
            return Comparer<ComparableFakeType>.Default.Compare(left, right) <= 0;
        }

        public static bool operator >=(ComparableFakeType left, ComparableFakeType right)
        {
            return Comparer<ComparableFakeType>.Default.Compare(left, right) >= 0;
        }
    }
}