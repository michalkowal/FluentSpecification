using JetBrains.Annotations;

namespace FluentSpecification.Core.Validation
{
    /// <summary>
    ///     Internal message modifier structure for trace message composition.
    ///     Used by <see cref="SpecificationResultGenerator" />.
    /// </summary>
    [PublicAPI]
    public struct TraceMessageModifier
    {
        /// <summary>
        ///     Create modifier struct.
        /// </summary>
        /// <param name="connector">Connector string. See <see cref="Connector" />.</param>
        /// <param name="mergeFormat">Single message format. See <see cref="MergeFormat" />.</param>
        /// <param name="overallFormat">Whole message format. See <see cref="OverallFormat" />.</param>
        [PublicAPI]
        public TraceMessageModifier([CanBeNull] string connector, [CanBeNull] string mergeFormat = "{0}",
            [CanBeNull] string overallFormat = "{0}")
        {
            Connector = connector;
            MergeFormat = mergeFormat;
            OverallFormat = overallFormat;
        }

        /// <summary>
        ///     String connector of two separate trace messages.
        /// </summary>
        /// <example>
        ///     <para>And</para>
        ///     <para>Or</para>
        /// </example>
        [PublicAPI]
        [CanBeNull]
        public string Connector { get; }

        /// <summary>
        ///     Single trace message string format
        /// </summary>
        /// <example>
        ///     Not({0})
        /// </example>
        [PublicAPI]
        [CanBeNull]
        public string MergeFormat { get; }

        /// <summary>
        ///     Whole message string format
        /// </summary>
        /// <example>
        ///     Not({0})
        /// </example>
        [PublicAPI]
        [CanBeNull]
        public string OverallFormat { get; }
    }
}