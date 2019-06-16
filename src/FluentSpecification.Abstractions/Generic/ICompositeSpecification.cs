using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Used for composing <c>Specifications</c> e.g. in fluent API.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface ICompositeSpecification<T>
        : ISpecification<T>
    {
        /// <summary>
        ///     "Left" <c>Specification</c>, ready for compose.
        /// </summary>
        [PublicAPI]
        [NotNull]
        ISpecification<T> BaseSpecification { get; }

        /// <summary>
        ///     Compose two separate <c>Specifications</c> (<see cref="BaseSpecification" /> and <paramref name="other" />) into
        ///     one.
        /// </summary>
        /// <remarks>
        ///     <para>Result of Composing is always <see cref="IComplexSpecification{T}" />.</para>
        /// </remarks>
        /// <param name="other">Compose with.</param>
        /// <returns>
        ///     Complex <c>Specification</c> (<see cref="IComplexSpecification{T}" />) composed by
        ///     <see cref="BaseSpecification" /> and <paramref name="other" />.
        /// </returns>
        [NotNull]
        ISpecification<T> Compose([NotNull] ISpecification<T> other);
    }
}