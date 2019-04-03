using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using FluentSpecification.Core;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if string is valid credit card number.
    /// </summary>
    [PublicAPI]
    public sealed class CreditCardSpecification :
        ComplexSpecification<string>
    {
        private const string AmexCard = "^3[47][0-9]{13}$";
        private const string BcGlobal = "^(6541|6556)[0-9]{12}$";
        private const string CarteBlancheCard = "^389[0-9]{11}$";
        private const string DinersClubCard = "^3(?:0[0-5]|[68][0-9])[0-9]{11}$";

        private const string DiscoverCard =
            "^65[4-9][0-9]{13}|64[4-9][0-9]{13}|6011[0-9]{12}|(622(?:12[6-9]|1[3-9][0-9]|[2-8][0-9][0-9]|9[01][0-9]|92[0-5])[0-9]{10})$";

        private const string InstaPaymentCard = "^63[7-9][0-9]{13}$";
        private const string JcbCard = @"^(?:2131|1800|35\d{3})\d{11}$";
        private const string KoreanLocalCard = "^9[0-9]{15}$";
        private const string LaserCard = "^(6304|6706|6709|6771)[0-9]{12,15}$";
        private const string MaestroCard = "^(5018|5020|5038|6304|6759|6761|6763)[0-9]{8,15}$";

        private const string MasterCard =
            "^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$";

        private const string SoloCard = "^(6334|6767)[0-9]{12}|(6334|6767)[0-9]{14}|(6334|6767)[0-9]{15}$";

        private const string SwitchCard =
            "^(4903|4905|4911|4936|6333|6759)[0-9]{12}|(4903|4905|4911|4936|6333|6759)[0-9]{14}|(4903|4905|4911|4936|6333|6759)[0-9]{15}|564182[0-9]{10}|564182[0-9]{12}|564182[0-9]{13}|633110[0-9]{10}|633110[0-9]{12}|633110[0-9]{13}$";

        private const string UnionPayCard = "^(62[0-9]{14,17})$";
        private const string VisaCard = "^4[0-9]{12}(?:[0-9]{3})?$";
        private const string VisaMasterCard = "^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$";

        private readonly MethodInfo _isMatchMethodInfo;
        private readonly MethodInfo _replaceMethodInfo;

        /// <summary>
        ///     Basic constructor.
        /// </summary>
        [PublicAPI]
        public CreditCardSpecification()
        {
            _isMatchMethodInfo = typeof(Regex).GetMethod(nameof(Regex.IsMatch),
                BindingFlags.Public | BindingFlags.Static,
                null,
                new[] {typeof(string), typeof(string)},
                null);
            _replaceMethodInfo = typeof(Regex).GetMethod(nameof(Regex.Replace),
                new[] {typeof(string), typeof(string), typeof(string)});
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage(string candidate)
        {
            return "Value is not correct credit card number";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateNegationFailedMessage(string candidate)
        {
            return "Value is correct credit card number";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return null;
        }

        private Expression CreateMatchExpression(Expression replaceExpression, string pattern)
        {
            return Expression.Call(_isMatchMethodInfo, replaceExpression, Expression.Constant(pattern));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override Expression BuildExpressionBody(Expression arg)
        {
            var checkNullExpression = Expression.NotEqual(arg, Expression.Constant(null, typeof(string)));
            var checkEmptyStringExpression = Expression.NotEqual(arg, Expression.Constant(string.Empty));
            var checkExpression = Expression.AndAlso(checkNullExpression, checkEmptyStringExpression);

            var replaceExpression = Expression.Call(_replaceMethodInfo, arg,
                Expression.Constant("[^0-9]"), Expression.Constant(string.Empty));
            var isMatchExpressions = new[]
            {
                CreateMatchExpression(replaceExpression, AmexCard),
                CreateMatchExpression(replaceExpression, BcGlobal),
                CreateMatchExpression(replaceExpression, CarteBlancheCard),
                CreateMatchExpression(replaceExpression, DinersClubCard),
                CreateMatchExpression(replaceExpression, DiscoverCard),
                CreateMatchExpression(replaceExpression, InstaPaymentCard),
                CreateMatchExpression(replaceExpression, JcbCard),
                CreateMatchExpression(replaceExpression, KoreanLocalCard),
                CreateMatchExpression(replaceExpression, LaserCard),
                CreateMatchExpression(replaceExpression, MaestroCard),
                CreateMatchExpression(replaceExpression, MasterCard),
                CreateMatchExpression(replaceExpression, SoloCard),
                CreateMatchExpression(replaceExpression, SwitchCard),
                CreateMatchExpression(replaceExpression, UnionPayCard),
                CreateMatchExpression(replaceExpression, VisaCard),
                CreateMatchExpression(replaceExpression, VisaMasterCard)
            };
            var isMatchExpression = Expression.OrElse(isMatchExpressions[0], isMatchExpressions[1]);
            for (var i = 2; i < isMatchExpressions.Length; i++)
                isMatchExpression = Expression.OrElse(isMatchExpression, isMatchExpressions[i]);

            var expression = Expression.AndAlso(checkExpression, isMatchExpression);
            return expression;
        }
    }
}