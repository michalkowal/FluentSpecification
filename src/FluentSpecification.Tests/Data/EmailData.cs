using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class EmailData : SpecificationData<string>
    {
        public EmailData()
        {
            var result = new SpecificationResult(true, "EmailSpecification");
            var invalidNegationResult = new SpecificationResult(false, "NotEmailSpecification+Failed",
                new FailedSpecification(typeof(EmailSpecification), null, (object) null, "String is valid email"));
            Valid("email@example.com").Result(result).NegationResult(invalidNegationResult);
            Valid("firstname.lastname@example.com").Result(result).NegationResult(invalidNegationResult);
            Valid("email@subdomain.example.com").Result(result).NegationResult(invalidNegationResult);
            Valid("firstname+lastname@example.com").Result(result).NegationResult(invalidNegationResult);
            Valid("email@123.123.123.123").Result(result).NegationResult(invalidNegationResult);
            Valid("email@[123.123.123.123]").Result(result).NegationResult(invalidNegationResult);
            Valid("\"email\"@example.com").Result(result).NegationResult(invalidNegationResult);
            Valid("1234567890@example.com").Result(result).NegationResult(invalidNegationResult);
            Valid("email@example-one.com").Result(result).NegationResult(invalidNegationResult);
            Valid("email@example.name").Result(result).NegationResult(invalidNegationResult);
            Valid("email@example.museum").Result(result).NegationResult(invalidNegationResult);
            Valid("email@example.co.jp").Result(result).NegationResult(invalidNegationResult);
            Valid("firstname-lastname@example.com").Result(result).NegationResult(invalidNegationResult);

            var invalidResult = new SpecificationResult(false, "EmailSpecification+Failed",
                new FailedSpecification(typeof(EmailSpecification), null, (object) null, "String is invalid email"));
            var validNegationResult = new SpecificationResult(true, "NotEmailSpecification");
            Invalid(null).Result(invalidResult).NegationResult(validNegationResult);
            Invalid("").Result(invalidResult).NegationResult(validNegationResult);
            Invalid(" ").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("\t").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("plainAddress").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("#@%^%#$@#$@#.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("@example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("Joe Smith <email@example.com>").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email.example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email@example@example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid(".email@example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email.@example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email..email@example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("あいうえお@example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email@example.com (Joe Smith)").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email@example").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email@-example.com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("email@example..com").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("Abc..123@example.com").Result(invalidResult).NegationResult(validNegationResult);
        }
    }
}