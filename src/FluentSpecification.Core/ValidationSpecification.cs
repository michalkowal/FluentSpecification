using System;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Core.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Base implementation of <see cref="IValidationSpecification{T}" />.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public abstract class ValidationSpecification<T> :
        IValidationSpecification<T>
    {
        /// <inheritdoc />
        public abstract bool IsSatisfiedBy(T candidate);

        /// <inheritdoc />
        public bool IsSatisfiedBy(T candidate, out SpecificationResult result)
        {
            var isSatisfiedBy = IsSatisfiedBy(candidate);

            result = CreateResult(candidate, isSatisfiedBy);

            return isSatisfiedBy;
        }

        /// <summary>
        ///     Creates <see cref="SpecificationResult" /> validation object with:
        /// </summary>
        /// <remarks>
        ///     Result contains:
        ///     <list type="bullet">
        ///         <item>
        ///             <term>trace message</term>
        ///         </item>
        ///         <item>
        ///             <term>
        ///                 <c>FailedSpecification</c>
        ///             </term>
        ///         </item>
        ///         <item>
        ///             <term>error message</term>
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
        protected virtual SpecificationResult CreateResult([CanBeNull] T candidate, bool isSatisfiedBy)
        {
            var traceMessage = new CommonSpecificationTrace(this, isSatisfiedBy);
            var info = new CommonSpecificationInfo<T>(this, candidate, isSatisfiedBy);

            SpecificationResult result = new SpecificationResult(isSatisfiedBy, traceMessage, info);

            return result;
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Func{T,TResult}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Func<T, bool>([NotNull] ValidationSpecification<T> self)
        {
            return self.IsSatisfiedBy;
        }
    }
}