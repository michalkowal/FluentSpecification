using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Common.Abstractions;
using JetBrains.Annotations;

namespace FluentSpecification.Common
{
    /// <summary>
    ///     Checks if <see cref="ISpecification{T}" /> is satisfied by ALL elements in candidate collection.
    /// </summary>
    /// <typeparam name="T">Collection type to iterate (<see cref="IEnumerable{T}" />).</typeparam>
    /// <typeparam name="TType">Type of collection element to verify.</typeparam>
    [PublicAPI]
    public sealed class AllSpecification<T, TType> :
        BaseCollectionSpecification<T, TType>
        where T : IEnumerable<TType>
    {
        /// <inheritdoc />
        [PublicAPI]
        public AllSpecification([NotNull] ISpecification<TType> specificationForAll, bool linqToEntities = false) :
            base(specificationForAll, linqToEntities)
        {
            var baseMethod = typeof(Enumerable).GetTypeInfo()
                .GetDeclaredMethod(nameof(Enumerable.All));
            CollectionElementCallMethodInfo = baseMethod.MakeGenericMethod(typeof(TType));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override MethodInfo CollectionElementCallMethodInfo { get; }

        /// <inheritdoc />
        [PublicAPI]
        protected override bool OverallForEmpty => true;

        /// <inheritdoc />
        [PublicAPI]
        protected override string TraceConnector => "And";

        /// <summary>
        ///     Checks if <typeparamref name="TType" /> <c>Specification</c> is satisfied by
        ///     ALL <paramref name="candidate" /> elements.
        /// </summary>
        /// <param name="candidate">Candidate object to verification.</param>
        /// <returns>
        ///     <para>true - <c>Specification</c> is satisfied by <paramref name="candidate" /> elements.</para>
        ///     <para>
        ///         false - is not satisfied or <paramref name="candidate" /> is null.
        ///     </para>
        /// </returns>
        [PublicAPI]
        public override bool IsSatisfiedBy(T candidate)
        {
            return candidate != null && candidate.All(c => CollectionElementSpecification.IsSatisfiedBy(c));
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override bool CanContinue(bool elementOverall, ref bool overall)
        {
            if (!elementOverall) overall = false;

            return true;
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override string CreateFailedMessage()
        {
            return "One or more elements are not specified";
        }

        /// <inheritdoc />
        [PublicAPI]
        protected override IReadOnlyDictionary<string, object> GetParameters()
        {
            return new Dictionary<string, object>
            {
                {"SpecificationForAll", CollectionElementSpecification}
            };
        }
    }
}