using System;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Base negation of generic <c>Linq</c> <c>Specification</c> interface.
    /// </summary>
    /// <remarks>
    ///     <para>Default "handler" for all kinds of negation generic <c>Linq</c> <c>Specifications</c>.</para>
    ///     <para>Can be used for searching valid objects in collections or DB sets.</para>
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface INegatableLinqSpecification<T> :
        INegatableSpecification<T>
    {
        /// <summary>
        ///     Gets typed lambda <c>Linq</c> Expression with candidate object verification.
        /// </summary>
        /// <returns>Strongly typed lambda <c>Linq</c> Expression.</returns>
        [PublicAPI]
        [NotNull]
        Expression<Func<T, bool>> GetNegationExpression();
    }
}