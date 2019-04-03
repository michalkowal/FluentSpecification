using System.Collections;

namespace FluentSpecification.Tests.Mocks
{
    public class InterFakeType : IEnumerable
    {
        public bool Third { get; set; }

        public IEnumerator GetEnumerator()
        {
            return new[] {Third}.GetEnumerator();
        }
    }
}