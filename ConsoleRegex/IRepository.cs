using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegex
{
	public interface IRepository
	{
		Task<(int, string, string)> InsertDataProduct1(string param1, string param2);
	}
}
