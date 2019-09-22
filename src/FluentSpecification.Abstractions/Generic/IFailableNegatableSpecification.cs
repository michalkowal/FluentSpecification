using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    [PublicAPI]
    public interface IFailableNegatableSpecification<T>
    {
        [PublicAPI]
        [NotNull]
        string GetFailedNegationMessage([CanBeNull] T candidate);
    }
}
