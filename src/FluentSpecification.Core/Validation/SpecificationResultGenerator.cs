using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            var failedSpecifications = new List<SpecificationInfo>();
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
    }
}