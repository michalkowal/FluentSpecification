using System.Collections.Generic;
using System.Linq;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    public partial class PropertySpecification<T, [PublicAPI] TProperty>
    {
        /// <summary>
        ///     Checks if <c>Specification</c> is satisfied by <paramref name="candidate" /> property value.
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
        ///         false - is not satisfied or <paramref name="candidate" /> is null
        ///         or his reference property is null.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            if (!TryGetPropertyValue(candidate, out var propertyValue))
            {
                result = CreateResult(candidate, null, false);
                return false;
            }

            var isSatisfiedBy = _propertySpecification.IsSatisfiedBy(propertyValue, out var propertyResult);

            result = CreateResult(candidate, propertyResult, isSatisfiedBy);

            return isSatisfiedBy;
        }

        [NotNull]
        [ItemNotNull]
        private IEnumerable<SpecificationInfo> CreateFailedSpecifications(
            [NotNull] IReadOnlyCollection<SpecificationInfo> propertyFailedSpecifications)
        {
            foreach (var propError in propertyFailedSpecifications)
                yield return new SpecificationInfo(
                    propError.SpecificationType,
                    propError.Parameters,
                    propError.Candidate,
                    propError.Errors.Select(e => $"Field '{_propertyName}': [{e}]").ToArray());
        }

        [NotNull]
        private string CreatePropertyFailedMessage()
        {
            return
                $"Field '{_propertyName}' value is not valid";
        }

        [NotNull]
        private string CreateTraceMessage([CanBeNull] string propertyTrace, bool result)
        {
            var message = $"{SpecificationResultGenerator.GetSpecificationShortName(this)}({propertyTrace})";
            if (!result)
                message += "+Failed";

            return message;
        }

        private IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"PropertySelector", _selector},
                {"PropertyName", _propertyName},
                {"PropertySpecification", _propertySpecification}
            };
        }

        [NotNull]
        private SpecificationResult CreateResult([CanBeNull] T candidate,
            [CanBeNull] SpecificationResult propertyResult, bool isSatisfiedBy)
        {
            var traceMessage = CreateTraceMessage(propertyResult?.Trace, isSatisfiedBy);
            var errors = new List<SpecificationInfo>();

            if (!isSatisfiedBy)
            {
                errors.Add(
                    new SpecificationInfo(GetType(), GetParameters(), candidate, CreatePropertyFailedMessage()));
                if (propertyResult != null)
                    errors.AddRange(CreateFailedSpecifications(propertyResult.FailedSpecifications));
            }

            var result = new SpecificationResult((propertyResult?.TotalSpecificationsCount ?? 0) + 1, isSatisfiedBy,
                traceMessage, errors.ToArray());
            return result;
        }
    }
}