using ConsoleUtility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleWithoutGenericHost
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			var serviceCollections = ConfigureServiceCollection();

			ITry tryService = new Try(serviceCollections);
			await tryService.PrintKeyOne();
		}

		static ServiceCollection ConfigureServiceCollection()
		{
            var services = new ServiceCollection();

			// Build a config object, using env vars and JSON providers.
			IConfigurationRoot config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();

			// Get values from the config given their key and their target type.
			Settings? settings = config.GetSection("Settings").Get<Settings>();

			services.AddSingleton(config);
			services.AddSingleton(settings);

			// Write the values to the console.
			
			Console.WriteLine($"KeyTwo = {settings?.KeyTwo}");
			Console.WriteLine($"KeyThree:Message = {settings?.KeyThree?.Message}");

			return services;
		}
	}
}