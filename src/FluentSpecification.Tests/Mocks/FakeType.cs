using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FluentSpecification.Tests.Mocks
{
    public class FakeType :
        IEnumerable<int>
    {
        public int First { get; set; }
        public string Second { get; set; }
        public InterFakeType Inter { get; } = null;
        public IEnumerable<int> Fourth { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            return (Fourth ?? Enumerable.Empty<int>()).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return Second ?? $"Fake({First})";
        }
    }
}