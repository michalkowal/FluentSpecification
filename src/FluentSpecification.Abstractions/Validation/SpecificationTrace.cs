using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Validation
{
    public struct SpecificationTrace
    {
        public static readonly SpecificationTrace Empty = new SpecificationTrace();

        public SpecificationTrace(string fullTrace, string shortTrace)
        {
            FullTrace = fullTrace;
            ShortTrace = shortTrace;
        }

        [PublicAPI]
        [CanBeNull]
        public string FullTrace { get; }
        [PublicAPI]
        [CanBeNull]
        public string ShortTrace { get; }

        public override string ToString()
        {
            return FullTrace;
        }

        public static SpecificationTrace Join([CanBeNull] string separator,
            [NotNull] IEnumerable<SpecificationTrace> values)
        {
            values = values ?? throw new ArgumentNullException(nameof(values));

            var fullTrace = string.Join(separator, values.Select(v => v.FullTrace));
            var shortTrace = string.Join(separator, values.Select(v => v.ShortTrace));

            return new SpecificationTrace(fullTrace, shortTrace);
        }
    }
}
