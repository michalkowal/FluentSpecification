using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LessThanOrEqualNullableData : SpecificationData<int?, int?>
    {
        public LessThanOrEqualNullableData()
        {
            Valid(null, 0)
                .Result("LessThanOrEqualSpecification<Nullable<Int32>>")
                .NegationResult("NotLessThanOrEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int?>),
                        "Object is lower than or equal to [0]")
                    .Candidate(null)
                    .AddParameter("LessThan", 0));
            Valid(null, null)
                .Result("LessThanOrEqualSpecification<Nullable<Int32>>")
                .NegationResult("NotLessThanOrEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int?>),
                        "Object is lower than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));

            Invalid(0, null)
                .NegationResult("NotLessThanOrEqualSpecification<Nullable<Int32>>")
                .Result("LessThanOrEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LessThanOrEqualSpecification<int?>), "Object is greater than [null]")
                    .Candidate(0)
                    .AddParameter("LessThan", null));
        }
    }
}