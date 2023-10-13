using ConsoleTryCatch.Interfaces;
using ConsoleTryCatch.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryCatch.Services
{
	public class MainService : IMainService
	{
		private readonly IMainRepository _mainRepository = new MainRepository();

		public void TestMethod()
		{
			Console.WriteLine($"Class: {MethodBase.GetCurrentMethod()?.DeclaringType?.Name}, Method: {MethodBase.GetCurrentMethod()?.Name}");
			_mainRepository.TestMethod();
		}
	}
}
