using System;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Validation
{
    public struct CommonSpecificationTrace
    {
        private readonly SpecificationTrace _trace;

        public CommonSpecificationTrace(ISpecification specification, bool result)
        {
            _trace = GetTrace(specification, result, null);
        }

        internal CommonSpecificationTrace(ISpecification specification, bool result, SpecificationTrace inner)
        {
            _trace = GetTrace(specification, result, inner);
        }

        public string FullTrace => _trace.FullTrace;
        public string ShortTrace => _trace.ShortTrace;

        private static SpecificationTrace GetTrace([NotNull] ISpecification specification, bool result,
            SpecificationTrace? inner)
        {
            if ((specification ?? throw new ArgumentNullException(nameof(specification))) is ITraceableSpecification
                traceableSpecification)
                return traceableSpecification.GetTrace(result);

            var fullTrace = specification.GetShortName();
            var shortTrace = fullTrace.Replace("Specification", string.Empty);

            if (inner.HasValue)
            {
                fullTrace += $"({inner.Value.FullTrace})";
                shortTrace += $"({inner.Value.ShortTrace})";
            }

            if (!result)
            {
                fullTrace += "+Failed";
                shortTrace += "+Failed";
            }

            return new SpecificationTrace(fullTrace, shortTrace);
        }

        [PublicAPI]
        public static implicit operator SpecificationTrace(CommonSpecificationTrace self)
        {
            return self._trace;
        }
    }
}
