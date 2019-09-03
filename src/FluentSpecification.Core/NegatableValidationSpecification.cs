using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Base implementation of <see cref="INegatableValidationSpecification{T}" />.
    ///     Inherited functionality from <see cref="ValidationSpecification{T}" />.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public abstract class NegatableValidationSpecification<T> :
        ValidationSpecification<T>,
        INegatableValidationSpecification<T>
    {
        /// <inheritdoc />
        [PublicAPI]
        public bool IsNotSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var isNotSatisfiedBy = IsNotSatisfiedBy(candidate);

            result = CreateNegationResult(candidate, isNotSatisfiedBy);

            return isNotSatisfiedBy;
        }

        /// <inheritdoc />
        [PublicAPI]
        public bool IsNotSatisfiedBy(T candidate)
        {
            return !IsSatisfiedBy(candidate);
        }

        /// <summary>
        ///     Creates <see cref="SpecificationResult" /> validation object for negation.
        /// </summary>
        /// <remarks>
        ///     Result contains:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>negation trace message</term>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 <c>FailedSpecification</c>
        ///             </term>
        ///         </item>
        ///         <item>
        ///             <term>negation error message</term>
        ///         </item>
        ///         <item>
        ///             <term>parameters</term>
        ///         </item>
        ///     </list>
        /// </remarks>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <param name="isSatisfiedBy">Overall result is <c>Specification</c> satisfied by candidate.</param>
        /// <returns>Validation object based on overall result and candidate content.</returns>
        [PublicAPI]
        [NotNull]
        protected virtual SpecificationResult CreateNegationResult([CanBeNull] T candidate, bool isSatisfiedBy)
        {
            var traceMessage = CreateNegationTraceMessage(candidate, isSatisfiedBy);

            SpecificationResult result;
            if (isSatisfiedBy)
                result = new SpecificationResult(true, traceMessage);
            else
                result = new SpecificationResult(false, traceMessage,
                    new SpecificationInfo(GetType(), GetParameters(), candidate,
                        CreateNegationFailedMessage(candidate)));

            return result;
        }

        /// <summary>
        ///     Creates negation trace message based on overall result and candidate content.
        /// </summary>
        /// <remarks>
        ///     Returns short name of <c>Specification</c> (without namespaces) with <c>Not</c> prefix, by default.
        ///     Failed result contains <c>+Failed</c> suffix.
        /// </remarks>
        /// <param name="candidate">Verified candidate object.</param>
        /// <param name="result">Overall <c>Specification</c> result.</param>
        /// <returns>Short negation trace message.</returns>
        [PublicAPI]
        [NotNull]
        protected virtual string CreateNegationTraceMessage([CanBeNull] T candidate, bool result)
        {
            return $"Not{CreateTraceMessage(candidate, result)}";
        }

        /// <summary>
        ///     Gets validation negation failed message of <c>Specification</c> for <paramref name="candidate" /> content.
        /// </summary>
        /// <remarks>
        ///     Invoked only when overall result is <c>False</c>.
        /// </remarks>
        /// <param name="candidate">Incorrect candidate object.</param>
        /// <returns>Validation negation failed message.</returns>
        [PublicAPI]
        [NotNull]
        protected abstract string CreateNegationFailedMessage([CanBeNull] T candidate);
    }
}