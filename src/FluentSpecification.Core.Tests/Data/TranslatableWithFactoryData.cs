using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;
using System;

namespace FluentSpecification.Core.Tests.Data
{
    public class TranslatableWithFactoryData : SpecificationData<int, Func<int, string>>
    {
        public TranslatableWithFactoryData()
        {
            Invalid(145, c => $"Passed value = {c}")
                .Result("FailedFalseMockValidationSpecification[System.Int32]", c => c
                    .CustomError("Passed value = 145")
                    .FailedSpecification(typeof(FalseMockValidationSpecification<int>),
                        "MockValidationSpecification is not satisfied")
                    .Candidate(145)
                    .AddParameter("Result", false));
        }
    }
}
