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

			Validations.Validation1(customer); // not good
			Validations.Validation2(customer); // good
		}
	}
}