using System;
using System.Collections.Generic;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Validation
{
    public class CommonSpecificationInfo<T> : SpecificationInfo
    {
        public CommonSpecificationInfo([NotNull] ISpecification<T> specification, [CanBeNull] T candidate, bool overallResult)
            : this(specification, candidate, overallResult, true)
        {
        }

        internal CommonSpecificationInfo([NotNull] ISpecification<T> specification, [CanBeNull] T candidate, bool overallResult, bool isNegation)
            : base(overallResult, specification.GetType(), isNegation, GetParameters(specification),
                candidate, GetErrorMessage(specification, candidate, overallResult, isNegation))
        {
        }

        [CanBeNull]
        private static IReadOnlyDictionary<string, object> GetParameters([NotNull] ISpecification specification)
        {
            specification = specification ?? throw new ArgumentNullException(nameof(specification));

            if (specification is IParameterizedSpecification parameterizedSpecification)
            {
                return parameterizedSpecification.GetParameters();
            }

            return null;
        }

        [CanBeNull]
        private static string GetErrorMessage<T>([NotNull] ISpecification<T> specification, T candidate,
            bool overallResult, bool isNegation)
        {
            specification = specification ?? throw new ArgumentNullException(nameof(specification));

            if (overallResult)
                return null;

            if (!isNegation)
            {
                if (specification is IFailableSpecification<T> failableSpecification)
                {
                    return failableSpecification.GetFailedMessage(candidate);
                }
            }
            else
            {
                if (specification is IFailableNegatableSpecification<T> failableSpecification)
                {
                    return failableSpecification.GetFailedNegationMessage(candidate);
                }
            }

            return null;
        }
    }
}
