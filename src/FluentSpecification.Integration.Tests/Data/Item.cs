using System;

namespace FluentSpecification.Integration.Tests.Data
{
    public class Item : IEquatable<Item>
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Paid { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public bool Equals(Item other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ItemId == other.ItemId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            // ReSharper disable once NonReadonlyMemberInGetHashCode
            return ItemId;
        }

        public static bool operator ==(Item left, Item right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Item left, Item right)
        {
            return !Equals(left, right);
        }
    }
}