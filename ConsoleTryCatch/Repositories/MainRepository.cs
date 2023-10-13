using ConsoleTryCatch.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryCatch.Repositories
{
	public class MainRepository : IMainRepository
	{
		public void TestMethod()
		{
			Console.WriteLine($"Class: {MethodBase.GetCurrentMethod()?.DeclaringType?.Name}, Method: {MethodBase.GetCurrentMethod()?.Name}");
			throw new ArgumentNullException("message");

			//try
			//{
			//	Console.WriteLine($"Class: {MethodBase.GetCurrentMethod()?.DeclaringType?.Name}, Method: {MethodBase.GetCurrentMethod()?.Name}");
			//	throw new ArgumentNullException("message");
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.ToString());
			//}
		}
	}
}
