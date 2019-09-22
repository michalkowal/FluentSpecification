using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Validation
{
    public struct GroupingSpecificationTrace
    {
        private readonly SpecificationTrace _trace;

        public GroupingSpecificationTrace(ISpecification specification, bool result, SpecificationTrace inner)
        {
            _trace = new CommonSpecificationTrace(specification, result, inner);
        }

        public string FullTrace => _trace.FullTrace;
        public string ShortTrace => _trace.ShortTrace;

        [PublicAPI]
        public static implicit operator SpecificationTrace(GroupingSpecificationTrace self)
        {
            return self._trace;
        }
    }
}
