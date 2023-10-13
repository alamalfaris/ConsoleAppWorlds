using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegex
{
	public class Repository : IRepository
	{
		public async Task<(int, string, string)> InsertDataProduct1(string param1, string param2)
		{
			return await Task.FromResult((1, "yes", "yes"));
		} 
	}
}
