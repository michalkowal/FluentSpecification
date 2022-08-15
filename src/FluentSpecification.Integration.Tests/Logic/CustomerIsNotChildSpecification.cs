using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal class CustomerIsNotChildSpecification : ISpecification<Customer>
    {
        public bool IsSatisfiedBy(Customer candidate)
        {
            return candidate != null && candidate.CaretakerId == null;
        }
    }
}
