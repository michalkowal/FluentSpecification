using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Base negation of generic <c>Specification</c> interface.
    /// </summary>
    /// <remarks>
    ///     <para>Default "handler" for all kinds of negation generic <c>Specifications</c>.</para>
    ///     <para>Used for negation check, for example object is not null or not equal.</para>
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface INegatableSpecification<in T> : ISpecification
    {
        /// <summary>
        ///     Checks if <c>Specification</c> is NOT satisfied by <paramref name="candidate" /> object.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is NOT satisfied by <paramref name="candidate" />.</para>
        ///     <para>false - is satisfied.</para>
        /// </returns>
        [PublicAPI]
        bool IsNotSatisfiedBy([CanBeNull] T candidate);
    }
}