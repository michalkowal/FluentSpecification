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
    }
}
