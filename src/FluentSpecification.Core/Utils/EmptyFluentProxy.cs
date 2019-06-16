using FluentSpecification.Abstractions.Generic;

namespace FluentSpecification.Core.Utils
{
    internal class EmptyFluentProxy<T> :
        IEntrySpecification<T>
    {
        public bool IsSatisfiedBy(T candidate)
        {
            return true;
        }
    }
}
