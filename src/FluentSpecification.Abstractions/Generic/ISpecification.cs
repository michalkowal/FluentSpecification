using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Base generic <c>Specification</c> interface.
    /// </summary>
    /// <remarks>
    ///     Default "handler" for all kinds of generic <c>Specifications</c>.
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface ISpecification<in T> : ISpecification
    {
        /// <summary>
        ///     Checks if <c>Specification</c> is satisfied by <paramref name="candidate" /> object.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" />.</para>
        ///     <para>false - is not.</para>
        /// </returns>
        [PublicAPI]
        bool IsSatisfiedBy([CanBeNull] T candidate);
    }
}