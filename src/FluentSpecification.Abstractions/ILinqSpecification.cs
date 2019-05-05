using System.Linq.Expressions;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions
{
    /// <summary>
    ///     Base <c>Linq</c> <c>Specification</c> interface.
    /// </summary>
    /// <remarks>
    ///     Default "handler" for all kinds of <c>Linq</c> <c>Specifications</c>.
    /// </remarks>
    [PublicAPI]
    public interface ILinqSpecification : ISpecification
    {
        /// <summary>
        ///     Gets <c>Linq</c> Expression with candidate object verification.
        /// </summary>
        /// <returns><c>Linq</c> expression.</returns>
        [NotNull]
        Expression GetExpression();
    }
}