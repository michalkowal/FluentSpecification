using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FluentSpecification.Core.Tests.Mocks
{
    public class FakeType : IEnumerable<char>
    {
        public int First { get; set; }
        public string Second { get; set; }
        public InterFakeType Inter { get; set; }

        public IEnumerator<char> GetEnumerator()
        {
            return (Second ?? Enumerable.Empty<char>()).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}