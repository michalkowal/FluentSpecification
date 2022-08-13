using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal class CustomerHasNotChildSpecification : ISpecification<Customer>
    {
        public bool IsSatisfiedBy(Customer candidate)
        {
            return candidate.CaretakerId == null;
        }
    }
}
