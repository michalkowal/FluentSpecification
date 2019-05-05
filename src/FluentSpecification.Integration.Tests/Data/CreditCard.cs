using System;

namespace FluentSpecification.Integration.Tests.Data
{
    public class CreditCard : IEquatable<CreditCard>
    {
        public int CustomerId { get; set; }
        public string CardNumber { get; set; }
        public DateTime ValidityDate { get; set; }

        public virtual Customer Customer { get; set; }

        public bool Equals(CreditCard other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return CustomerId == other.CustomerId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((CreditCard) obj);
        }

        public override int GetHashCode()
        {
            // ReSharper disable once NonReadonlyMemberInGetHashCode
            return CustomerId;
        }

        public static bool operator ==(CreditCard left, CreditCard right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreditCard left, CreditCard right)
        {
            return !Equals(left, right);
        }
    }
}