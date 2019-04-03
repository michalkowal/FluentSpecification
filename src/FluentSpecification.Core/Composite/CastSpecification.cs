using System;
using System.Linq;
using System.Linq.Expressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    /// <summary>
    ///     Converts <c>Specification</c> (candidate to verification)
    ///     from <typeparamref name="T" /> to <typeparamref name="TCast" />.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    /// <typeparam name="TCast">Type of candidate to verify after cast.</typeparam>
    [PublicAPI]
    public sealed partial class CastSpecification<T, TCast> :
        IComplexSpecification<T>
    {
        private readonly Expression<Func<T, bool>> _expression;
        private readonly IComplexSpecification<TCast> _specification;

        /// <summary>
        ///     Creates "converted" <c>Specification</c>.
        /// </summary>
        /// <param name="specification">Specification to convert.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="specification" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when there is no conversion between
        ///     <typeparamref name="T" /> and <typeparamref name="TCast" />.
        /// </exception>
        [PublicAPI]
        public CastSpecification([NotNull] ISpecification<TCast> specification)
        {
            specification = specification ?? throw new ArgumentNullException(nameof(specification));

            _specification = specification.AsComplexSpecification();

            _expression = CreateExpression(_specification.GetExpression());
        }

        /// <summary>
        ///     Checks if <c>Specification</c> is satisfied by <paramref name="candidate" /> object.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" />.</para>
        ///     <para>
        ///         false - is not satisfied or cannot cast <paramref name="candidate" />
        ///         from <typeparamref name="T" /> to <typeparamref name="TCast" />.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate)
        {
            try
            {
                var converted = (TCast) (object) candidate;
                return _specification.IsSatisfiedBy(converted);
            }
            catch (InvalidCastException)
            {
                return false;
            }
        }

        /// <summary>
        ///     Gets typed lambda <c>Linq</c> Expression with candidate object verification.
        /// </summary>
        /// <returns>Strongly typed lambda <c>Linq</c> Expression.</returns>
        /// <exception cref="InvalidCastException">
        ///     Thrown when cannot cast candidate
        ///     from <typeparamref name="T" /> to <typeparamref name="TCast" />
        /// </exception>
        [PublicAPI]
        public Expression<Func<T, bool>> GetExpression()
        {
            return _expression;
        }

        /// <summary>
        ///     Gets <c>Linq</c> Expression with candidate object verification.
        /// </summary>
        /// <returns><c>Linq</c> expression.</returns>
        /// <exception cref="InvalidCastException">
        ///     Thrown when cannot cast candidate
        ///     from <typeparamref name="T" /> to <typeparamref name="TCast" />
        /// </exception>
        [PublicAPI]
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        [NotNull]
        private Expression ReplaceExpressionParameters([NotNull] Expression cast,
            [NotNull] Expression<Func<TCast, bool>> baseExpression)
        {
            // build parameter map (from parameters of second to parameters of first)
            var map = baseExpression.Parameters.ToDictionary(p => p, p => cast);

            // replace parameters in the second lambda expression with parameters from the first
            var newBody = ExpressionParameterRebinder.ReplaceParameters(map, baseExpression.Body);
            return newBody;
        }

        [NotNull]
        private Expression<Func<T, bool>> CreateExpression([NotNull] Expression<Func<TCast, bool>> baseExpression)
        {
            var arg = Expression.Parameter(typeof(T), "candidate");
            var cast = Expression.Convert(arg, typeof(TCast));

            var body = ReplaceExpressionParameters(cast, baseExpression);
            return Expression.Lambda<Func<T, bool>>(body, arg);
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Expression<Func<T, bool>>([NotNull] CastSpecification<T, TCast> self)
        {
            return self.GetExpression();
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Func{T, Boolean}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Func<T, bool>([NotNull] CastSpecification<T, TCast> self)
        {
            return self.IsSatisfiedBy;
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static explicit operator Expression([NotNull] CastSpecification<T, TCast> self)
        {
            return ((ILinqSpecification) self).GetExpression();
        }
    }
}