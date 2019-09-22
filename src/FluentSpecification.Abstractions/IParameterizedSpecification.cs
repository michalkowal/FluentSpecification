using System.Collections.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions
{
    [PublicAPI]
    public interface IParameterizedSpecification
    {
        [PublicAPI]
        [NotNull]
        IReadOnlyDictionary<string, object> GetParameters();
    }
}
