using log4net.Config;
using log4net;
using System.Reflection;
using Log4Net.LogUtility;

namespace ConsoleLog4Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingInitialize();
            var logs = new Logger();

            logs.Info("Starting the application");

            try
            {
                logs.Debug($"Starting method {MethodBase.GetCurrentMethod()?.DeclaringType}");
                throw new Exception("Sample Error inside the try catch block code");
            }
            catch (Exception ex)
            {
                logs.Error(ex.Message, ex.InnerException);
            }

            logs.Debug("Waiting for user input");
            Console.ReadLine();
            logs.Info("Ending application");
        }

        static void LoggingInitialize()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        }
    }
}