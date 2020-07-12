namespace FluentSpecification.Abstractions.Generic
{
    public interface IComplexNegatableSpecification<T> :
        INegatableValidationSpecification<T>,
        INegatableLinqSpecification<T>
    {
    }
}
