using ConsoleTryCatch.Interfaces;
using ConsoleTryCatch.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryCatch.Controllers
{
	public class MainController : IMainController
	{
		private readonly IMainService mainService = new MainService();

		public void TestMethod()
		{
			// 1st trial: try catch only in controller
			// 2nd trial: try catch in controller, repository
			try
			{
				Console.WriteLine($"Class: {MethodBase.GetCurrentMethod()?.DeclaringType?.Name}, Method: {MethodBase.GetCurrentMethod()?.Name}");
				mainService.TestMethod();
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message} | Location: {ex.StackTrace}");
			}
		}
	}
}
