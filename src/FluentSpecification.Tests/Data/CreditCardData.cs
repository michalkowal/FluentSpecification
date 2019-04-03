using FluentSpecification.Abstractions.Validation;
using FluentSpecification.Common;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class CreditCardData : SpecificationData<string>
    {
        public CreditCardData()
        {
            var result = new SpecificationResult(true, "CreditCardSpecification");
            var invalidNegationResult = new SpecificationResult(false, "NotCreditCardSpecification+Failed",
                new FailedSpecification(typeof(CreditCardSpecification), null, (object) null,
                    "Value is correct credit card number"));
            Valid("4111 1111 1111 1111").Result(result).NegationResult(invalidNegationResult); // Visa
            Valid("5500 0000 0000 0004").Result(result).NegationResult(invalidNegationResult); // MasterCard
            Valid("3400-0000-0000-009").Result(result).NegationResult(invalidNegationResult); // Amex
            Valid("3000 0000 0000 04").Result(result).NegationResult(invalidNegationResult); // Diner's Club
            Valid("6011,0000,0000,0004").Result(result).NegationResult(invalidNegationResult); // Discover
            Valid("3566002020360505").Result(result).NegationResult(invalidNegationResult); // JCB
            Valid("6759649826438453").Result(result).NegationResult(invalidNegationResult); // Maestro
            Valid("5555 5555 5555 8726").Result(result).NegationResult(invalidNegationResult);
            Valid("378282246310005").Result(result).NegationResult(invalidNegationResult);
            Valid("3530111333300000").Result(result).NegationResult(invalidNegationResult);
            Valid("4917484589897107").Result(result).NegationResult(invalidNegationResult);

            var invalidResult = new SpecificationResult(false, "CreditCardSpecification+Failed",
                new FailedSpecification(typeof(CreditCardSpecification), null, (object) null,
                    "Value is not correct credit card number"));
            var validNegationResult = new SpecificationResult(true, "NotCreditCardSpecification");
            Invalid(null).Result(invalidResult).NegationResult(validNegationResult);
            Invalid("").Result(invalidResult).NegationResult(validNegationResult);
            Invalid(" ").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("\t").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("plaintext").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("123456789").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("6745 5555 5555 8726").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("479282246310035").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("1430111333300000").Result(invalidResult).NegationResult(validNegationResult);
            Invalid("0917484589897107").Result(invalidResult).NegationResult(validNegationResult);
        }
    }
}