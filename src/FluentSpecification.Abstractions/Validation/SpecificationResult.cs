using System;
using System.Collections.Generic;
using System.Linq;
using FluentSpecification.Abstractions.Generic;
using JetBrains.Annotations;

namespace FluentSpecification.Abstractions.Validation
{
    /// <summary>
    ///     Contains summary of validation scenarios.
    ///     See <see cref="IValidationSpecification{T}" /> and <see cref="INegatableValidationSpecification{T}" />.
    /// </summary>
    /// <remarks>Contains information about <c>Specifications</c> chain and validation errors.</remarks>
    [PublicAPI]
    public class SpecificationResult
    {
        /// <summary>
        ///     Create "empty" result for successful single <c>Specification</c>.
        /// </summary>
        [PublicAPI]
        public SpecificationResult() :
            this(SpecificationTrace.Empty)
        {
        }


        /// <summary>
        ///     Create "empty" result with trace, for successful single <c>Specification</c>.
        /// </summary>
        /// <param name="trace">
        ///     <para>Trace message.</para>
        ///     <para>Should contains short identifier of executed <c>Specifications</c> and relation between them.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(SpecificationTrace trace) :
            this(1, true, trace)
        {
        }

        /// <summary>
        ///     Create result for single <c>Specification</c>.
        /// </summary>
        /// <param name="overallResult">Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.</param>
        /// <param name="specifications">
        ///     <para>List of <c>Specifications</c> in chain.</para>
        ///     <para>For definition see <see cref="SpecificationInfo" />.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(bool overallResult,
            [CanBeNull] [ItemNotNull] params SpecificationInfo[] specifications) :
            this(overallResult, SpecificationTrace.Empty, specifications)
        {
        }

        /// <summary>
        ///     Create result with trace, for single <c>Specification</c>.
        /// </summary>
        /// <param name="overallResult">Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.</param>
        /// <param name="trace">
        ///     <para>Trace message.</para>
        ///     <para>Should contains short identifier of executed <c>Specifications</c> and relation between them.</para>
        /// </param>
        /// <param name="specifications">
        ///     <para>List of <c>Specifications</c> in chains.</para>
        ///     <para>For definition see <see cref="SpecificationInfo" />.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(bool overallResult, SpecificationTrace trace,
            [CanBeNull] [ItemNotNull] params SpecificationInfo[] specifications) :
            this(1, overallResult, trace, specifications)
        {
        }

        /// <summary>
        ///     Create result for combined multiple <c>Specifications</c>.
        /// </summary>
        /// <param name="totalSpecificationsCount">Count of all executed <c>Specifications</c> in chain.</param>
        /// <param name="overallResult">Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.</param>
        /// <param name="trace">
        ///     <para>Trace message.</para>
        ///     <para>Should contains short identifier of executed <c>Specifications</c> and relation between them.</para>
        /// </param>
        /// <param name="specifications">
        ///     <para>List of <c>Specifications</c> in chain.</para>
        ///     <para>For definition see <see cref="SpecificationInfo" />.</para>
        /// </param>
        [PublicAPI]
        public SpecificationResult(int totalSpecificationsCount, bool overallResult, SpecificationTrace trace,
            params SpecificationInfo[] specifications)
        {
            TotalSpecificationsCount = totalSpecificationsCount;
            OverallResult = overallResult;
            Specifications = specifications ?? new SpecificationInfo[0];
            Trace = trace;
        }

        /// <summary>
        ///     Count of all executed <c>Specifications</c> in chain.
        /// </summary>
        [PublicAPI]
        public int TotalSpecificationsCount { get; }

        /// <summary>
        ///     Overall result returned by <c>IsSatisfiedBy</c> or <c>IsNotSatisfiedBy</c> method.
        /// </summary>
        [PublicAPI]
        public bool OverallResult { get; }

        /// <summary>
        ///     List of <c>Specifications</c> in chain.
        /// </summary>
        /// <remarks>For definition see <see cref="SpecificationInfo" />.</remarks>
        [PublicAPI]
        [NotNull]
        public IReadOnlyList<SpecificationInfo> Specifications { get; }

        /// <summary>
        ///     List of failed <c>Specifications</c>.
        /// </summary>
        /// <remarks>For definition see <see cref="SpecificationInfo" />.</remarks>
        [PublicAPI]
        [NotNull]
        public IReadOnlyList<SpecificationInfo> FailedSpecifications => Specifications.Where(s => !s.Result).ToArray();

        /// <summary>
        ///     Trace message.
        /// </summary>
        /// <remarks>
        ///     Excellent for debugging <c>Specifications</c> chain behavior from left to right.
        /// </remarks>
        /// <value>Should contains short identifier of executed <c>Specifications</c> and relation between them.</value>
        [PublicAPI]
        public SpecificationTrace Trace { get; }

        /// <summary>
        ///     Count of failed <c>Specifications</c>.
        /// </summary>
        [PublicAPI]
        public int FailedSpecificationsCount => FailedSpecifications.Count;

        /// <summary>
        ///     All failed <c>Specifications</c> errors.
        /// </summary>
        [PublicAPI]
        [NotNull]
        public IReadOnlyList<string> Errors => FailedSpecifications.SelectMany(fs => fs.Errors).ToArray();


        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>All <c>Specifications</c> errors combined into one string.</returns>
        public override string ToString()
        {
            var result = string.Join(Environment.NewLine, Errors);
            return result;
        }
    }
}