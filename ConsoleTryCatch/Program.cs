using ConsoleTryCatch.Controllers;
using ConsoleTryCatch.Interfaces;

namespace ConsoleTryCatch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			IMainController mainController = new MainController();
			mainController.TestMethod();
		}
	}
}