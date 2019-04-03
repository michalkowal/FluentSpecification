using System;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    public abstract partial class CompositeSpecification<T>
    {
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


            var traceModifier = new TraceMessageModifier(
                TraceMessageConnector, _grouping ? "({0})" : null);

            result = SpecificationResultGenerator.GenerateOverallSpecificationResult(specResult,
                         traceModifier, leftResult, rightResult) ?? throw new InvalidOperationException();

            return specResult;
        }
    }
}