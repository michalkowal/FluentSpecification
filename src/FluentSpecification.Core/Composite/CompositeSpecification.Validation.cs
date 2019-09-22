using System;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    public abstract partial class CompositeSpecification<T>
    {
        struct CompositeSpecificationTrace
        {
            private readonly SpecificationTrace _trace;

            public CompositeSpecificationTrace(SpecificationTrace left, SpecificationTrace right,
                string connector, bool grouping)
            {
                _trace = new SpecificationTrace(
                    GenerateTrace(left.FullTrace, right.FullTrace, connector, grouping),
                    GenerateTrace(left.ShortTrace, right.ShortTrace, connector, grouping));
            }

            private string GenerateTrace(string left, string right, string connector, bool grouping)
            {
                if (!string.IsNullOrEmpty(left) && !string.IsNullOrEmpty(right))
                {
                    var tmpRight = grouping ? $"({right})" : right;
                    return $"{left} {connector} {tmpRight}";
                }
                if (!string.IsNullOrEmpty(left))
                {
                    return left;
                }
                if (!string.IsNullOrEmpty(right))
                {
                    return right;
                }

                return null;
            }

            [PublicAPI]
            public static implicit operator SpecificationTrace(CompositeSpecificationTrace self)
            {
                return self._trace;
            }
        }

        /// <summary>
        ///     String used as connection between trace message from
        ///     "left" and "right" <c>Specifications</c>.
        /// </summary>
        [PublicAPI]
        [NotNull]
        protected abstract string TraceMessageConnector { get; }

        /// <summary>
        ///     Merge results from <c>Specifications</c> passed in constructor.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <param name="result">
        ///     Contains validation summary of two separate <c>Specifications</c> -
        ///     errors, types of all executed <c>Specifications</c>
        ///     and trace message in the style of Boole algebra.
        /// </param>
        /// <returns>
        ///     Overall result as composition of two <c>Specifications</c>.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when merge of results is null.</exception>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var leftSpecResult = _left.IsSatisfiedBy(candidate, out var leftResult);
            var rightSpecResult = _right.IsSatisfiedBy(candidate, out var rightResult);
            var specResult = Merge(leftSpecResult, rightSpecResult);

            var finalTrace = new CompositeSpecificationTrace(leftResult.Trace, rightResult.Trace, 
                TraceMessageConnector, _grouping);

            result = leftResult.Merge(specResult, finalTrace, rightResult);

            return specResult;
        }
    }
}