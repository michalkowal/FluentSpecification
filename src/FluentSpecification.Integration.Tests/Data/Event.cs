using System;

namespace FluentSpecification.Integration.Tests.Data
{
    public class Event : IEquatable<Event>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsArchival { get; set; }

        public bool Equals(Event other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Event) obj);
        }

        public override int GetHashCode()
        {
            // ReSharper disable once NonReadonlyMemberInGetHashCode
            return Id;
        }

        public static bool operator ==(Event left, Event right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Event left, Event right)
        {
            return !Equals(left, right);
        }
    }
}