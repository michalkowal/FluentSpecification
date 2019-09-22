using FluentSpecification.Abstractions.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Validation
{
    public class NegationSpecificationInfo<T> : CommonSpecificationInfo<T>
    {
        public NegationSpecificationInfo([NotNull] ISpecification<T> specification, [CanBeNull] T candidate, bool overallResult)
            : base(specification, candidate, overallResult, true)
        {
        }
    }
}
