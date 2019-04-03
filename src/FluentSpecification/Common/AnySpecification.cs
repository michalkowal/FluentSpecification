using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if <see cref="ISpecification{T}" /> is satisfied by ANY element in candidate collection.
    /// </summary>
    /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{T}" />).</typeparam>
    /// <typeparam name="TType">Type of collection element to verify.</typeparam>
    [PublicAPI]
    public sealed class AnySpecification<T, TType> :
        BaseCollectionSpecification<T, TType>
        where T : IEnumerable<TType>
    {
        /// <inheritdoc />
        [PublicAPI]
        public AnySpecification([NotNull] ISpecification<TType> specificationForAny, bool linqToEntities = false) :
            base(specificationForAny, linqToEntities)
        {
            var baseMethod = typeof(Enumerable)
                .GetMethods().First(m => m.Name == nameof(Enumerable.Any) && m.GetParameters().Length == 2);
            CollectionElementCallMethodInfo = baseMethod.MakeGenericMethod(typeof(TType));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override MethodInfo CollectionElementCallMethodInfo { get; }

        /// <inheritdoc />
        [PublicAPI]
        protected override bool OverallForEmpty => false;

        /// <inheritdoc />
        [PublicAPI]
        protected override string TraceConnector => "Or";

        /// <summary>
        ///     Checks if <typeparamref name="TType" /> <c>Specification</c> is satisfied by
        ///     ANY <paramref name="candidate" /> element.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" /> element.</para>
        ///     <para>
        ///         false - is not satisfied or <paramref name="candidate" /> is null.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public override bool IsSatisfiedBy(T candidate)
        {
            return candidate != null && candidate.Any(c => CollectionElementSpecification.IsSatisfiedBy(c));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override bool CanContinue(bool elementOverall, ref bool overall)
        {
            if (elementOverall)
            {
                overall = true;
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage()
        {
            return "All elements are not specified";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"SpecificationForAny", CollectionElementSpecification}
            };
        }
    }
}