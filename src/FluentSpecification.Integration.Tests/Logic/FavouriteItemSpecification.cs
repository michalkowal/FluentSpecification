using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Integration.Tests.Data;

namespace FluentSpecification.Integration.Tests.Logic
{
    internal sealed class FavoriteItemSpecification : ISpecification<Event>
    {
        public bool IsSatisfiedBy(Event candidate)
        {
            return candidate != null && !candidate.IsArchival &&
                   (candidate.Code.Contains("-") || candidate.Code.Contains(".")) &&
                   !candidate.Name.ToUpper().Contains("BULLET") && candidate.Id < 5;
        }
    }
}