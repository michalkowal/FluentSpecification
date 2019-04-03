using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    /// <summary>
    ///     Base generic <c>Specification</c> interface for
    ///     complex solutions with validation and <c>Linq</c> support.
    /// </summary>
    /// <remarks>
    ///     <para>Default "handler" for all kinds of complex <c>Specifications</c>.</para>
    /// </remarks>
    /// <typeparam name="T">Type of candidate to verify.</typeparam>
    [PublicAPI]
    public interface IComplexSpecification<T> :
        IValidationSpecification<T>,
        ILinqSpecification<T>
    {
    }
}