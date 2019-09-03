using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions
{
    [PublicAPI]
    public interface ITraceableSpecification
    {
        [PublicAPI]
        SpecificationTrace GetTrace(bool result);
    }
}
