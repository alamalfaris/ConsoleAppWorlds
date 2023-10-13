using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleRegex
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			string userName = "ass";
			string identificationNo = "aa";//"111111";
			string txtDate = "a a";//"20/02/2023";
			string email = "aa";//"alamalfaris97@gmail.com";
			string gender = "11";

			//object[] parameters = { string.Empty, string.Empty };
			//Type type = typeof(IRepository);
			//MethodInfo? method = type.GetMethod("InsertDataProduct1");
			//IRepository repository = new Repository();
			//if (method is not null)
			//{
			//	var result = (Task<(int, string, string)>)method.Invoke(repository, parameters)!;
			//	Console.WriteLine($"{result.Result.Item1}, {result.Result.Item2}, {result.Result.Item3}");
			//}

			if (!gender.Trim().Equals("L") && !gender.Trim().Equals("P"))
			{
				Console.WriteLine("masuk validasi");
			}

			if (!Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
			{
				Console.WriteLine("masuk validasi");
			}

			if (!Regex.Match(identificationNo.Trim(), "^[0-9]+$").Success) // bisa buat validasi no rekening dan no ktp
			{
				// TODO.
				Console.WriteLine("masuk validasi");
			}

			//&& Regex.Match(userName, "^[A-Za-z]+$").Success
			if (!Regex.Match(userName.Trim(), "^[A-Za-z ]+$").Success)
			{
				Console.WriteLine("masuk validasi");
			}

			if (!Regex.Match(txtDate.Trim(), @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$").Success)
			{
				Console.WriteLine("masuk validasi");
			}
		}
	}
}