using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class LessThanNullableData : SpecificationData<int?, int?>
    {
        public LessThanNullableData()
        {
            Valid(null, 0)
                .Result("LessThanSpecification<Nullable<Int32>>")
                .NegationResult("NotLessThanSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int?>), "Object is lower than [0]")
                    .Candidate(null)
                    .AddParameter("LessThan", 0));

            Invalid(0, null)
                .NegationResult("NotLessThanSpecification<Nullable<Int32>>")
                .Result("LessThanSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int?>),
                        "Object is greater than or equal to [null]")
                    .Candidate(0)
                    .AddParameter("LessThan", null));
            Invalid(null, null)
                .NegationResult("NotLessThanSpecification<Nullable<Int32>>")
                .Result("LessThanSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(LessThanSpecification<int?>),
                        "Object is greater than or equal to [null]")
                    .Candidate(null)
                    .AddParameter("LessThan", null));
        }
    }
}