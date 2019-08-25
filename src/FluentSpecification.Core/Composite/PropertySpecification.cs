using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Composite
{
    /// <summary>
    ///     Verifies if <c>Specification</c> is satisfied by candidate property value.
    /// </summary>
    /// <typeparam name="T">Type of candidate.</typeparam>
    /// <typeparam name="TProperty">Type of candidate property to verify.</typeparam>
    [PublicAPI]
    public sealed partial class PropertySpecification<T, TProperty> :
        IComplexSpecification<T>
    {
        private const string SelectorPattern = "^[a-zA-Z_][a-zA-Z0-9_.]*$";
        private readonly Expression<Func<T, bool>> _expression;
        private readonly string _propertyName;

        private readonly IComplexSpecification<TProperty> _propertySpecification;
        private readonly Expression<Func<T, TProperty>> _selector;

        /// <summary>
        ///     Creates <c>Specification</c> for candidate property
        /// </summary>
        /// <param name="selector">Property selector.</param>
        /// <param name="propertySpecification">Specification to verify value of candidate property.</param>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="selector" /> or
        ///     <paramref name="propertySpecification" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="selector" /> is not valid.</exception>
        [PublicAPI]
        public PropertySpecification([NotNull] Expression<Func<T, TProperty>> selector,
            [NotNull] ISpecification<TProperty> propertySpecification)
        {
            propertySpecification =
                propertySpecification ?? throw new ArgumentNullException(nameof(propertySpecification));

            _selector = IsSelectorValid(selector ?? throw new ArgumentNullException(nameof(selector)))
                ? selector
                : throw new ArgumentException("Incorrect property selector expression", nameof(selector));
            _propertySpecification = propertySpecification.AsComplexSpecification();

            _expression = ReplaceExpressionParameters(_selector, _propertySpecification.GetExpression());
            _propertyName = GetPropertyName(_selector);
        }

        /// <summary>
        ///     Checks if <c>Specification</c> is satisfied by <paramref name="candidate" /> property value.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" /> property value.</para>
        ///     <para>
        ///         false - is not satisfied or <paramref name="candidate" /> is null
        ///         or his reference property is null.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public bool IsSatisfiedBy(T candidate)
        {
            if (!TryGetPropertyValue(candidate, out var propertyValue))
                return false;
            return _propertySpecification.IsSatisfiedBy(propertyValue);
        }

        /// <summary>
        ///     Gets typed lambda <c>Linq</c> Expression with candidate property verification.
        /// </summary>
        /// <returns>Strongly typed lambda <c>Linq</c> Expression.</returns>
        /// <exception cref="NullReferenceException">
        ///     Thrown when candidate is null
        ///     or his reference property is null.
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
        /// <exception cref="NullReferenceException">
        ///     Thrown when candidate is null
        ///     or his reference property is null.
        /// </exception>
        [PublicAPI]
        Expression ILinqSpecification.GetExpression()
        {
            return GetExpression();
        }

        [NotNull]
        private Expression<Func<T, bool>> ReplaceExpressionParameters(
            [NotNull] Expression<Func<T, TProperty>> selector, [NotNull] Expression<Func<TProperty, bool>> expression)
        {
            // build parameter map (from parameters of second to parameters of first)
            var map = expression.Parameters.ToDictionary(p => p, p => selector.Body);

            // replace parameters in the second lambda expression with parameters from the first
            var newBody = ExpressionParameterRebinder.ReplaceParameters(map, expression.Body);

            // apply composition of lambda expression bodies to parameters from the first expression 
            return Expression.Lambda<Func<T, bool>>(newBody, selector.Parameters);
        }

        private bool IsSelectorValid([NotNull] Expression<Func<T, TProperty>> selector)
        {
            var selectorBody = selector.Body.ToString();
            return selectorBody.Contains(selector.Parameters.First().Name) &&
                   Regex.IsMatch(selectorBody, SelectorPattern);
        }

        private string GetPropertyName([NotNull] Expression<Func<T, TProperty>> selector)
        {
            var selectorStr = selector.Body.ToString();
            var idx = selectorStr.IndexOf('.') + 1;
            var prop = selectorStr.Substring(idx);

            return prop;
        }

        private bool TryGetPropertyValue([CanBeNull] T candidate, [CanBeNull] out TProperty value)
        {
            try
            {
                value = _selector.Compile().Invoke(candidate);
                return true;
            }
            catch (NullReferenceException)
            {
                value = default;
                return false;
            }
        }

        /// <summary>
        ///     Conversion operator from <c>Specification</c> to <see cref="Expression{Func}" />.
        /// </summary>
        /// <param name="self">Converted object</param>
        /// <exception cref="NullReferenceException">Thrown when <paramref name="self" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static implicit operator Expression<Func<T, bool>>([NotNull] PropertySpecification<T, TProperty> self)
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
        public static implicit operator Func<T, bool>([NotNull] PropertySpecification<T, TProperty> self)
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
        public static explicit operator Expression([NotNull] PropertySpecification<T, TProperty> self)
        {
            return ((ILinqSpecification) self).GetExpression();
        }
    }
}