using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentSpecification.Abstractions;
using FluentSpecification.Abstractions.Validation;
using JetBrains.Annotations;

namespace FluentSpecification.Core.Validation
{
    /// <summary>
    ///     Helper class for generation of <see cref="SpecificationResult" /> validation object.
    /// </summary>
    [PublicAPI]
    public static class SpecificationResultGenerator
    {
        private const string SpecificationShortNameRegex = "[a-zA-Z][a-zA-Z0-9]*";

        [NotNull]
        private static string MergeTraces([ItemNotNull] List<string> traces, TraceMessageModifier traceModifier)
        {
            if (!string.IsNullOrWhiteSpace(traceModifier.MergeFormat))
                for (var i = 0; i < traces.Count; i++)
                    if (i != 0 || traces.Count == 1)
                        traces[i] = string.Format(traceModifier.MergeFormat, traces[i]);
            var finalTrace = string.Join($" {traceModifier.Connector} ", traces);
            if (!string.IsNullOrWhiteSpace(traceModifier.OverallFormat) && !string.IsNullOrEmpty(finalTrace))
                finalTrace = string.Format(
                    traceModifier.OverallFormat,
                    finalTrace);

            return finalTrace;
        }

        /// <summary>
        ///     Generate one <see cref="SpecificationResult" /> validation object, merged with multiple results.
        /// </summary>
        /// <param name="overallResult">Overall result of all <c>Specifications</c>.</param>
        /// <param name="traceModifier">Modifier struct for trace messages joining.</param>
        /// <param name="results">All results to merge.</param>
        /// <returns>Result containing information from <paramref name="results" />.</returns>
        [PublicAPI]
        [CanBeNull]
        public static SpecificationResult GenerateOverallSpecificationResult(
            bool overallResult, TraceMessageModifier traceModifier, [CanBeNull] params SpecificationResult[] results)
        {
            if (results == null || results.Length == 0)
                return null;

            var totalSpecificationsCount = 0;
            var failedSpecifications = new List<FailedSpecification>();
            var traces = new List<string>();
            foreach (var res in results)
            {
                totalSpecificationsCount += res.TotalSpecificationsCount;
                if (!overallResult)
                    failedSpecifications.AddRange(res.FailedSpecifications);
                if (!string.IsNullOrEmpty(res.Trace))
                    traces.Add(res.Trace);
            }

            var finalTrace = MergeTraces(traces, traceModifier);

            var mergeResult = new SpecificationResult(
                totalSpecificationsCount,
                overallResult,
                finalTrace,
                failedSpecifications.ToArray());

            return mergeResult;
        }

        /// <summary>
        ///     Get short name of type - without namespaces etc.
        /// </summary>
        /// <param name="type">Get name of.</param>
        /// <returns>Short name of <paramref name="type" />.</returns>
        /// <example>
        ///     <code>
        /// SpecificationResultGenerator.GetTypeShortName(typeof(List&lt;int[]&gt;)) // List&lt;Int32[]&gt;
        /// </code>
        /// </example>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="type" /> is null.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when <paramref name="type" /> is array and <c>GetElementType</c>
        ///     return null.
        /// </exception>
        [PublicAPI]
        [NotNull]
        public static string GetTypeShortName([NotNull] Type type)
        {
            type = type ?? throw new ArgumentNullException(nameof(type));

            var shortName = type.IsArray
                ? $"{GetTypeShortName(type.GetElementType() ?? throw new InvalidOperationException())}[]"
                : Regex.Match(type.Name, SpecificationShortNameRegex).Value;

            if (type.IsGenericType)
                shortName += $"<{string.Join(",", type.GenericTypeArguments.Select(GetTypeShortName))}>";

            return shortName;
        }

        /// <summary>
        ///     Get short name of <c>Specification</c> type - without namespaces etc.
        /// </summary>
        /// <param name="specification">Get name of.</param>
        /// <returns>Short name of <paramref name="specification" />.</returns>
        /// <seealso cref="GetTypeShortName" />
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="specification" /> is null.</exception>
        [PublicAPI]
        [NotNull]
        public static string GetSpecificationShortName([NotNull] ISpecification specification)
        {
            specification = specification ?? throw new ArgumentNullException(nameof(specification));

            var specType = specification.GetType();

            var shortName = GetTypeShortName(specType);

            return shortName;
        }
    }
}