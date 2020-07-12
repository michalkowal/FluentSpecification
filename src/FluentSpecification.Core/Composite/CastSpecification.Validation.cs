using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Utils;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    public partial class CastSpecification<T, TCast>
    {
        /// <summary>
        ///     Checks if <c>Specification</c> is satisfied by <paramref name="candidate" /> object.
        ///     Returns validation <paramref name="result" /> no matter is satisfied or not.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <param name="result">
        ///     Contains validation summary - errors, types of all executed <c>Specifications</c>
        ///     and trace message in the style of Boole algebra.
        /// </param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" />.</para>
        ///     <para>
        ///         false - is not satisfied or cannot cast <paramref name="candidate" />
        ///         from <typeparamref name="T" /> to <typeparamref name="TCast" />.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            SpecificationResult specResult;
            bool isSatisfiedBy = true;
            try
            {
                TCast converted = ConvertCandidate(candidate);
                _specification.IsSatisfiedBy(converted, out specResult);
            }
            catch (InvalidCastException)
            {
                specResult = null;
                isSatisfiedBy = false;
            }

            result = CreateResult(candidate, specResult, isSatisfiedBy);
            return result.OverallResult;
        }

        public string GetFailedMessage(T candidate)
        {
            var from = candidate != null
                ? candidate.GetType().GetShortName()
                : "null";

            return
                $"Cannot cast type [{from}] to " +
                $"[{typeof(TCast).GetShortName()}]";
        }

        private SpecificationTrace CreateTraceMessage(SpecificationTrace castTrace, bool result)
        {
            var trace = new GroupingSpecificationTrace(this, result, castTrace);

            return trace;
        }

        public IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"Specification", _specification}
            };
        }

        [NotNull]
        private SpecificationResult CreateResult([CanBeNull] T candidate,
            [CanBeNull] SpecificationResult propertyResult, bool isSatisfiedBy)
        {
            var traceMessage = CreateTraceMessage(propertyResult?.Trace ?? SpecificationTrace.Empty, isSatisfiedBy);
            var infos = new List<SpecificationInfo>()
            {
                new CommonSpecificationInfo<T>(this, candidate, isSatisfiedBy)
            };

            if (propertyResult != null)
                infos.AddRange(propertyResult.Specifications);

            var result = new SpecificationResult(propertyResult?.OverallResult ?? isSatisfiedBy,
                traceMessage, infos.ToArray());
            return result;
        }
    }
}