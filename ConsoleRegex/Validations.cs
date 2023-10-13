using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegex
{
	public static class Validations
	{
		public static void Validation1(Customer customer)
		{
			if (CommonValidations.IsNotAOrB(customer.Gender, "L", "P")
				&& CommonValidations.IsDatePatternValid(customer.BirthDate)
				&& CommonValidations.IsEmailPatternValid(customer.Email)
				&& CommonValidations.IsOnlyNumeric(customer.IdentificationNo)
				&& CommonValidations.IsOnlyAlphabeth(customer.CustomerName)
				)
			{
				Console.WriteLine("Kena validasi1");
			}
			else
			{
				Console.WriteLine("Ga kena validasi1");
			}
		}

		public static void Validation2(Customer customer)
		{
			(bool, string) validationResult;

			validationResult = CommonValidations.CheckValueNotAOrB(customer.Gender, "L", "P");
			if (!validationResult.Item1)
			{
				throw new CustomValidationException($"Value: {validationResult.Item2} invalid");
			}

			validationResult = CommonValidations.OnlyAlphabeth(customer.CustomerName);
			if (!validationResult.Item1)
			{
				throw new CustomValidationException($"Value: {validationResult.Item2} invalid");
			}

			validationResult = CommonValidations.OnlyNumeric(customer.IdentificationNo);
			if (!validationResult.Item1)
			{
				throw new CustomValidationException($"Value: {validationResult.Item2} invalid");
			}

			validationResult = CommonValidations.CheckDatePattern(customer.BirthDate);
			if (!validationResult.Item1)
			{
				throw new CustomValidationException($"Value: {validationResult.Item2} invalid");
			}

			validationResult = CommonValidations.CheckEmailPattern(customer.Email);
			if (!validationResult.Item1)
			{
				throw new CustomValidationException($"Value: {validationResult.Item2} invalid");
			}
		}
	}
}
