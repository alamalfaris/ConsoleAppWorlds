using System.Reflection;
using System.Runtime.CompilerServices;

namespace ConsoleReflection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			
			Type type = this.GetType();
			MethodInfo? method = type.GetMethod("Method1");
			method?.Invoke(this, null);
		}

		static async Task Method1([CallerMemberName] string name = "")
		{
			Console.WriteLine(MethodBase.GetCurrentMethod()?.Name);
			Console.WriteLine(name);
			await Task.CompletedTask;
		}
	}
}