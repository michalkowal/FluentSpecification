using FluentSpecification.Core.Tests.Mocks;
using FluentSpecification.Tests.Sdk.Data;
using System;
using System.Collections.Generic;

namespace FluentSpecification.Core.Tests.Data
{
    public class TranslatableWithFactoryAndParametersData :
        SpecificationData<int, Func<int, IReadOnlyDictionary<string, object>, string>>
    {
        public TranslatableWithFactoryAndParametersData()
        {
            Invalid(145, (c, p) => $"Passed value = {c}; With parameter = {p["Result"]}")
                .Result("FailedFalseMockValidationSpecification[System.Int32]", c => c
                    .CustomError("Passed value = 145; With parameter = False")
                    .FailedSpecification(typeof(FalseMockValidationSpecification<int>),
                        "MockValidationSpecification is not satisfied")
                    .Candidate(145)
                    .AddParameter("Result", false));
        }
    }
}
