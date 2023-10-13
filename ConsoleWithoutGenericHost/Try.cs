using ConsoleUtility;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWithoutGenericHost
{
	public class Try : ITry
	{
		private readonly ServiceCollection _services;
		public Try(ServiceCollection services)
		{
			_services = services;
		}

		public async Task PrintKeyOne()
		{
			await Task.Run(() =>
			{
				var servicesProvider = _services.BuildServiceProvider();
				var settings = servicesProvider.GetService<Settings>();

				Console.WriteLine($"KeyOne = {settings?.KeyOne}");
			});
			
		}
	}
}
