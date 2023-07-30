using ConsoleWithEfCore.Helpers;
using ConsoleWithEfCore.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleWithEfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServiceCollection();

            IStudentService studentService = new StudentService(services);
            var students = studentService.GetStudents();

            foreach(var student in students)
            {
                Console.WriteLine(student.Name);
            }
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

            return services;
        }
    }
}