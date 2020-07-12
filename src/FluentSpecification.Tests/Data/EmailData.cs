using FluentSpecification.Tests.Data.Factories;
using FluentSpecification.Tests.Data.Results.EmailSpecificationResults;
using FluentSpecification.Tests.Sdk.Data;

namespace FluentSpecification.Tests.Data
{
	public class EmailData : SpecificationData
	{
        private void Valid(string candidate)
        {
            AddValidWithResults<string, EmailValidResults, EmailNegationInvalidResults>(
                candidate, new EmailFactory());
        }
        private void Invalid(string candidate)
        {
            AddInvalidWithResults<string, EmailInvalidResults, EmailNegationValidResults>(
                candidate, new EmailFactory());
        }

		public EmailData()
		{
			Valid("email@example.com");
			Valid("firstname.lastname@example.com");
			Valid("email@subdomain.example.com");
			Valid("firstname+lastname@example.com");
			Valid("email@123.123.123.123");
			Valid("email@[123.123.123.123]");
			Valid("\"email\"@example.com");
			Valid("1234567890@example.com");
			Valid("email@example-one.com");
			Valid("email@example.name");
			Valid("email@example.museum");
			Valid("email@example.co.jp");
			Valid("firstname-lastname@example.com");

			Invalid(null);
			Invalid("");
			Invalid(" ");
			Invalid("\t");
			Invalid("plainAddress");
			Invalid("#@%^%#$@#$@#.com");
			Invalid("@example.com");
			Invalid("Joe Smith <email@example.com>");
			Invalid("email.example.com");
			Invalid("email@example@example.com");
			Invalid(".email@example.com");
			Invalid("email.@example.com");
			Invalid("email..email@example.com");
			Invalid("あいうえお@example.com");
			Invalid("email@example.com (Joe Smith)");
			Invalid("email@example");
			Invalid("email@-example.com");
			Invalid("email@example..com");
			Invalid("Abc..123@example.com");
		}
	}
}