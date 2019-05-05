using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions.Validation;
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
            bool overall;
            try
            {
                TCast converted;
                if (candidate is TCast)
                {
                    converted = (TCast)(object)candidate;
                }
                else
                {
                    converted = (TCast)Convert.ChangeType(candidate, typeof(TCast));
                }
                overall = _specification.IsSatisfiedBy(converted, out specResult);
            }
            catch (InvalidCastException)
            {
                specResult = null;
                overall = false;
            }

            result = CreateResult(candidate, specResult, overall);
            return overall;
        }

        [NotNull]
        private string CreatePropertyFailedMessage([CanBeNull] T candidate)
        {
            var from = candidate != null
                ? SpecificationResultGenerator.GetTypeShortName(candidate.GetType())
                : "null";

            return
                $"Cannot cast type [{from}] to " +
                $"[{SpecificationResultGenerator.GetTypeShortName(typeof(TCast))}]";
        }

        // TODO: Add Failed only when cast exception
        [NotNull]
        private string CreateTraceMessage([CanBeNull] string castTrace, bool result)
        {
            var message = $"{SpecificationResultGenerator.GetSpecificationShortName(this)}({castTrace})";
            if (!result)
                message += "+Failed";

            return message;
        }

        [NotNull]
        private IReadOnlyDictionary<string, object> GetParameters()
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
            var traceMessage = CreateTraceMessage(propertyResult?.Trace, isSatisfiedBy);
            var errors = new List<FailedSpecification>();

            if (!isSatisfiedBy)
            {
                if (propertyResult != null)
                    errors.AddRange(propertyResult.FailedSpecifications);
                else
                    errors.Add(new FailedSpecification(GetType(), GetParameters(), candidate,
                        CreatePropertyFailedMessage(candidate)));
            }

            var result = new SpecificationResult((propertyResult?.TotalSpecificationsCount ?? 0) + 1, isSatisfiedBy,
                traceMessage, errors.ToArray());
            return result;
        }
    }
}