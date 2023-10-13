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
				CustomerName = "Alam1",
				Gender = "L",
				IdentificationNo = "1234567890",
				Email = "alam123@gmail.com",
				BirthDate = "01/06/1997"
			};

			//Validations.Validation1(customer); // not good
			
			try
			{
				Validations.Validation2(customer); // good
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				Console.WriteLine($"Message: {ex.Message}");
				Console.WriteLine($"Inner exception: {ex.InnerException?.ToString()}");
				Console.WriteLine($"Target site: {ex.TargetSite?.Name}");
				Console.WriteLine($"Stack trace: {ex.StackTrace}");
				Console.WriteLine($"Source: {ex.Source}");
			}
		}
	}
}