using System.Reflection;

namespace ConsoleRegex
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Customer customer = new()
			{
				CustomerName = "Alam",
				Gender = "k",
				IdentificationNo = "1234567890",
				Email = "alam123@gmail.com",
				BirthDate = "01/06/1997"
			};

			Validation1(customer); // not good
			Validation2(customer); // good
		}

		static void Validation1(Customer customer)
		{
			if (Validations.IsNotAOrB(customer.Gender, "L", "P")
				&& Validations.IsDatePatternValid(customer.BirthDate)
				&& Validations.IsEmailPatternValid(customer.Email)
				&& Validations.IsOnlyNumeric(customer.IdentificationNo)
				&& Validations.IsOnlyAlphabeth(customer.CustomerName)
				)
			{
				Console.WriteLine("Kena validasi1");
			}
			else
			{
				Console.WriteLine("Ga kena validasi1");
			}
		}

		static void Validation2(Customer customer)
		{
			(bool, string) validationResult;

			validationResult = Validations.CheckValueNotAOrB(customer.Gender, "L", "P");
			if (!validationResult.Item1)
			{
				Console.WriteLine($"Value: {validationResult.Item2} invalid");
			}

			validationResult = Validations.OnlyAlphabeth(customer.CustomerName);
			if (!validationResult.Item1)
			{
				Console.WriteLine($"Value: {validationResult.Item2} invalid");
			}

			validationResult = Validations.OnlyNumeric(customer.IdentificationNo);
			if (!validationResult.Item1)
			{
				Console.WriteLine($"Value: {validationResult.Item2} invalid");
			}

			validationResult = Validations.CheckDatePattern(customer.BirthDate);
			if (!validationResult.Item1)
			{
				Console.WriteLine($"Value: {validationResult.Item2} invalid");
			}

			validationResult = Validations.CheckEmailPattern(customer.Email);
			if (!validationResult.Item1)
			{
				Console.WriteLine($"Value: {validationResult.Item2} invalid");
			}
		}
	}
}