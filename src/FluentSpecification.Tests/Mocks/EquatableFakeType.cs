using System;

namespace FluentSpecification.Tests.Mocks
{
    public class EquatableFakeType : FakeType,
        IEquatable<EquatableFakeType>
    {
        public bool Equals(EquatableFakeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return First == other.First;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is EquatableFakeType other && Equals(other);
        }

        public override int GetHashCode()
        {
            // ReSharper disable once NonReadonlyMemberInGetHashCode
            return First;
        }
    }
}