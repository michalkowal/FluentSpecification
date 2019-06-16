using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Utils
{
    /// <summary>
    ///     Used for composing <c>Specifications</c> by fluent API.
    ///     Join <c>Specifications</c> by logical OR.
    /// </summary>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    internal sealed class OrFluentProxy<T> :
        BaseFluentProxy<T>
    {
        /// <summary>
        ///     Create Proxy object
        /// </summary>
        /// <param name="baseSpecification">"Left" <c>Specification</c>, ready for compose.</param>
        public OrFluentProxy([NotNull] ISpecification<T> baseSpecification)
            : base(baseSpecification)
        {
        }

        /// <inheritdoc />
        protected override IComplexSpecification<T> OnCompose(ISpecification<T> other)
        {
            return new OrSpecification<T>(BaseSpecification, other);
        }
    }
}