using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using FluentSpecification.Abstractions.Generic;
using FluentSpecification.Core.Composite;
using FluentSpecification.Core.Utils;
using JetBrains.Annotations;

[assembly: InternalsVisibleTo("FluentSpecification.Core.Tests")]

namespace FluentSpecification.Core
{
    /// <summary>
    ///     Extensions for <see cref="ISpecification{T}" />.
    /// </summary>
    [PublicAPI]
    public static class Specification
    {
        /// <summary>
        ///     Global switch if <c>Linq Expressions</c> should be build for <c>LinqToEntities</c>.
        /// </summary>
        [PublicAPI]
        public static bool LinqToEntities { get; set; }

        public static IEntrySpecification<T> For<T>()
        {
            return new EmptyFluentProxy<T>();
        }
    }
}