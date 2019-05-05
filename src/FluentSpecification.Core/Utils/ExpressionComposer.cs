using System;
using System.Linq;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Utils
{
    /// <summary>
    ///     Helps compose multiple <c>Linq</c> <c>Expressions</c> into one.
    /// </summary>
    internal static class ExpressionComposer
    {
        /// <summary>
        ///     Compose one <c>Expression</c> with merge function.
        /// </summary>
        /// <typeparam name="TExpression">Type of <c>Expression</c>.</typeparam>
        /// <param name="left">Base <c>Expression</c>.</param>
        /// <param name="merge">Merge function.</param>
        /// <returns>
        ///     Lambda <c>Expression</c> created with <paramref name="left" /> <c>Expression</c>
        ///     and <paramref name="merge" /> function.
        /// </returns>
        /// <example>
        ///     <code>
        /// Expression&lt;Func&lt;string, bool&gt;&gt; baseExp = str => string.IsNullOrEmpty(str);
        /// Expression newExp = ExpressionComposer.Compose(baseExp, Expression.Not);    // str => Not(string.IsNullOrEmpty(str))
        /// </code>
        /// </example>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="left" /> or <paramref name="merge" /> is null.</exception>
        [NotNull]
        internal static Expression<TExpression> Compose<TExpression>([NotNull] Expression<TExpression> left,
            [NotNull] Func<Expression, Expression> merge)
        {
            left = left ?? throw new ArgumentNullException(nameof(left));
            merge = merge ?? throw new ArgumentNullException(nameof(merge));

            // apply composition of lambda expression bodies to parameters from the left expression 
            return Expression.Lambda<TExpression>(merge(left.Body), left.Parameters);
        }

        /// <summary>
        ///     Compose two <c>Expression</c> int one by merge function.
        /// </summary>
        /// <typeparam name="TExpression">Type of <c>Expression</c>.</typeparam>
        /// <param name="left">Base first <c>Expression</c>.</param>
        /// <param name="right">Base second <c>Expression</c>.</param>
        /// <param name="merge">Merge function.</param>
        /// <returns>
        ///     Lambda <c>Expression</c> created with <paramref name="left" />, <paramref name="right" /> <c>Expressions</c>
        ///     and <paramref name="merge" /> function.
        /// </returns>
        /// <example>
        ///     <code>
        /// Expression&lt;Func&lt;string, bool&gt;&gt; baseExp1 = str => string.IsNullOrEmpty(str);
        /// Expression&lt;Func&lt;string, bool&gt;&gt; baseExp2 = s => s.Length > 0;
        /// Expression newExp = ExpressionComposer.Compose(baseExp1, baseExp2, Expression.AndAlso);
        /// // str => string.IsNullOrEmpty(str) AndAlso (str.Length > 0)
        /// </code>
        /// </example>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when <paramref name="left" />, <paramref name="right" />
        ///     or <paramref name="merge" /> is null.
        /// </exception>
        internal static Expression<TExpression> Compose<TExpression>(Expression<TExpression> left,
            Expression<TExpression> right,
            Func<Expression, Expression, Expression> merge)
        {
            left = left ?? throw new ArgumentNullException(nameof(left));
            right = right ?? throw new ArgumentNullException(nameof(right));
            merge = merge ?? throw new ArgumentNullException(nameof(merge));

            // build parameter map (from parameters of right to parameters of left)
            var map = left.Parameters.Select((f, i) => new {f, s = right.Parameters[i]})
                .ToDictionary(p => p.s, p => (Expression) p.f);

            // replace parameters in the right lambda expression with parameters from the left
            var secondBody = ExpressionParameterRebinder.ReplaceParameters(map, right.Body);

            // apply composition of lambda expression bodies to parameters from the left expression 
            return Expression.Lambda<TExpression>(merge(left.Body, secondBody), left.Parameters);
        }
    }
}