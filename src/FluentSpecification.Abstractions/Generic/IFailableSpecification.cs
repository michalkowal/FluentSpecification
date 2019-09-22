using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Generic
{
    [PublicAPI]
    public interface IFailableSpecification<T>
    {
        [PublicAPI]
        [NotNull]
        string GetFailedMessage([CanBeNull] T candidate);
    }
}
