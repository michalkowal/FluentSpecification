using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Base generic <c>Specification</c> interface for
    ///     single objects validation scenarios.
    /// </summary>
    /// <remarks>
    ///     <para>Default "handler" for all kinds of generic <c>Specifications</c> for objects validation.</para>
    ///     <para>
    ///         Can be used for scenarios, where single objects needs verification with errors prepared for e.g. UI, like
    ///         DTOs.
    ///     </para>
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface IValidationSpecification<in T> :
        ISpecification<T>
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
        ///     <para>false - is not. <paramref name="result" /> should contains errors.</para>
        /// </returns>
        [PublicAPI]
        bool IsSatisfiedBy([CanBeNull] T candidate, [NotNull] out SpecificationResult result);
    }
}