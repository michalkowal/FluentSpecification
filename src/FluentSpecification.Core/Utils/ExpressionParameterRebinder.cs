using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Utils
{
    /// <summary>
    ///     Implementation of <see cref="ExpressionVisitor" />.
    ///     Used for remapping <c>Expression</c> parameters from one to another.
    /// </summary>
    public sealed class ExpressionParameterRebinder : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, Expression> _map;

        private ExpressionParameterRebinder([NotNull] Dictionary<ParameterExpression, Expression> map)
        {
            _map = map;
        }

        /// <summary>
        ///     Replace parameters in <c>Expression</c> and return new one with changed body.
        /// </summary>
        /// <param name="map">Map with base parameter and his substitution.</param>
        /// <param name="exp">Base <c>Expression</c></param>
        /// <returns>New <c>Expression</c> with changed body and parameters.</returns>
        /// <example>
        ///     <code>
        /// Expression arg = Expression.Parameter(typeof(Exception), "arg");
        /// Expression prop = Expression.Property(arg, "Message");
        /// Expression&lt;Func&lt;string, bool&gt;&gt; baseExp = str => string.IsNullOrEmpty(str);
        /// Expression newBody = ExpressionParameterRebinder.ReplaceParameters(new Dictionary&lt;ParameterExpression, Expression&gt;
        /// {
        ///     {baseExp.Parameters.First(), prop}
        /// }, baseExp.Body);   // string.IsNullOrEmpty(arg.Message)
        /// </code>
        /// </example>
        [NotNull]
        public static Expression ReplaceParameters([NotNull] Dictionary<ParameterExpression, Expression> map,
            [NotNull] Expression exp)
        {
            var result = new ExpressionParameterRebinder(map).Visit(exp);
            return result ?? exp;
        }

        /// <inheritdoc />
        protected override Expression VisitParameter(ParameterExpression p)
        {
            if (_map.TryGetValue(p, out var replacement)) return replacement;

            return base.VisitParameter(p);
        }
    }
}