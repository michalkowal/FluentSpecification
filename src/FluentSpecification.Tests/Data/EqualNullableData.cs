using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class EqualNullableData : SpecificationData<int?, int?>
    {
        public EqualNullableData()
        {
            Valid(null, null)
                .Result("EqualSpecification<Nullable<Int32>>")
                .NegationResult("NotEqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int?>), "Object is equal to [null]")
                    .Candidate(null)
                    .AddParameter("Expected", null));

            Invalid(0, null)
                .NegationResult("NotEqualSpecification<Nullable<Int32>>")
                .Result("EqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int?>), "Object is not equal to [null]")
                    .Candidate(0)
                    .AddParameter("Expected", null));
            Invalid(null, 0)
                .NegationResult("NotEqualSpecification<Nullable<Int32>>")
                .Result("EqualSpecification<Nullable<Int32>>+Failed", c => c
                    .FailedSpecification(typeof(EqualSpecification<int?>), "Object is not equal to [0]")
                    .Candidate(null)
                    .AddParameter("Expected", 0));
        }
    }
}