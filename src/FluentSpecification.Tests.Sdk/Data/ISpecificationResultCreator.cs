using System;

namespace FluentSpecification.Tests.Sdk.Data
{
    public interface ISpecificationResultCreator
    {
        FailedSpecificationDataRow FailedSpecification(Type specificationType, params string[] errors);
    }
}