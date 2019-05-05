using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Base negation of generic <c>Specification</c> interface for
    ///     single objects validation scenarios.
    /// </summary>
    /// <remarks>
    ///     <para>Default "handler" for all kinds of negation generic <c>Specifications</c> for objects validation.</para>
    ///     <para>
    ///         Can be used for negation check, where single objects needs verification with errors prepared for e.g. UI,
    ///         like DTOs.
    ///     </para>
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface INegatableValidationSpecification<in T> :
        INegatableSpecification<T>
    {
        /// <summary>
        ///     Checks if <c>Specification</c> is NOT satisfied by <paramref name="candidate" /> object.
        ///     Returns validation <paramref name="result" /> no matter is satisfied or not.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <param name="result">
        ///     Contains validation summary - errors, types of all executed <c>Specifications</c>
        ///     and trace message in the style of Boole algebra.
        /// </param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is NOT satisfied by <paramref name="candidate" />.</para>
        ///     <para>false - is satisfied. <paramref name="result" /> should contains errors.</para>
        /// </returns>
        [PublicAPI]
        bool IsNotSatisfiedBy([CanBeNull] T candidate, [NotNull] out SpecificationResult result);
    }
}