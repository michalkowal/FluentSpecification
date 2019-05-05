using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Integration.Tests.Data
{
    public class Customer : IEquatable<Customer>
    {
        public Customer()
        {
            // ReSharper disable once VirtualMemberCallInConstructor
            Items = new List<Item>();
        }

        public int CustomerId { get; set; }

        [UsedImplicitly] public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public bool IsActive { get; set; }

        public int? CaretakerId { get; set; }

        public virtual Customer Caretaker { get; set; }
        public virtual CreditCard CreditCard { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public bool Equals(Customer other)
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
            return Equals((Customer) obj);
        }

        public override int GetHashCode()
        {
            // ReSharper disable once NonReadonlyMemberInGetHashCode
            return CustomerId;
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !Equals(left, right);
        }
    }
}