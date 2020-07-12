using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.CreditCardSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
    public class CreditCardData : SpecificationData
    {
        private void Valid(string candidate)
        {
            AddValidWithResults<string, CreditCardValidResults, CreditCardNegationInvalidResults>(
                candidate, new CreditCardFactory());
        }
        private void Invalid(string candidate)
        {
            AddInvalidWithResults<string, CreditCardInvalidResults, CreditCardNegationValidResults>(
                candidate, new CreditCardFactory());
        }


        public CreditCardData()
        {
            Valid("4111 1111 1111 1111"); // Visa
            Valid("5500 0000 0000 0004"); // MasterCard
            Valid("3400-0000-0000-009"); // Amex
            Valid("3000 0000 0000 04"); // Diner's Club
            Valid("6011,0000,0000,0004"); // Discover
            Valid("3566002020360505"); // JCB
            Valid("6759649826438453"); // Maestro
            Valid("5555 5555 5555 8726");
            Valid("378282246310005");
            Valid("3530111333300000");
            Valid("4917484589897107");

            Invalid(null);
            Invalid("");
            Invalid(" ");
            Invalid("\t");
            Invalid("plaintext");
            Invalid("123456789");
            Invalid("6745 5555 5555 8726");
            Invalid("479282246310035");
            Invalid("1430111333300000");
            Invalid("0917484589897107");
        }
    }
}