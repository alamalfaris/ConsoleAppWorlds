using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleRegex
{
	public static class Validations
	{
		public static bool IsOnlyAlphabeth(string input)
		{
			if (!Regex.IsMatch(input.Trim(), "^[A-Za-z ]+$", 
				RegexOptions.None, TimeSpan.FromSeconds(5)))
			{
				return false;
			}
			return true;
		}

		public static bool IsOnlyNumeric(string input)
		{
			if (!Regex.IsMatch(input.Trim(), "^[0-9]+$", 
				RegexOptions.None, TimeSpan.FromSeconds(5)))
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Validate string date with pattern dd/MM/YYYY
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool IsDatePatternValid(string input)
		{
			if (!Regex.IsMatch(input.Trim(), @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", 
				RegexOptions.None, TimeSpan.FromSeconds(5)))
			{
				return false;
			}
			return true;
		}

		public static bool IsEmailPatternValid(string input)
		{
			if (!Regex.IsMatch(input.Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", 
				RegexOptions.IgnoreCase, TimeSpan.FromSeconds(5)))
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Validate input value not A or B
		/// </summary>
		/// <param name="input"></param>
		/// <param name="comparation1"></param>
		/// <param name="comparation2"></param>
		/// <returns></returns>
		public static bool IsNotAOrB(string input, string comparation1, string comparation2)
		{
			if (!input.Trim().ToUpper().Equals(comparation1.ToUpper()) && !input.Trim().ToUpper().Equals(comparation2.ToUpper()))
			{
				return false;
			}
			return true;
		}

		public static (bool, string) OnlyAlphabeth(string input)
		{
			if (!Regex.IsMatch(input.Trim(), "^[A-Za-z ]+$",
				RegexOptions.None, TimeSpan.FromSeconds(5)))
			{
				return (false, input);
			}
			return (true, input);
		}

		public static (bool, string) OnlyNumeric(string input)
		{
			if (!Regex.IsMatch(input.Trim(), "^[0-9]+$",
				RegexOptions.None, TimeSpan.FromSeconds(5)))
			{
				return (false, input);
			}
			return (true, input);
		}

		/// <summary>
		/// Validate string date with pattern dd/MM/YYYY
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static (bool, string) CheckDatePattern(string input)
		{
			if (!Regex.IsMatch(input.Trim(), @"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$",
				RegexOptions.None, TimeSpan.FromSeconds(5)))
			{
				return (false, input);
			}
			return (true, input);
		}

		public static (bool, string) CheckEmailPattern(string input)
		{
			if (!Regex.IsMatch(input.Trim(), @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
				RegexOptions.IgnoreCase, TimeSpan.FromSeconds(5)))
			{
				return (false, input);
			}
			return (true, input);
		}

		/// <summary>
		/// Validate input value not A or B
		/// </summary>
		/// <param name="input"></param>
		/// <param name="comparation1"></param>
		/// <param name="comparation2"></param>
		/// <returns></returns>
		public static (bool, string) CheckValueNotAOrB(string input, string comparation1, string comparation2)
		{
			if (!input.Trim().ToUpper().Equals(comparation1.ToUpper()) && !input.Trim().ToUpper().Equals(comparation2.ToUpper()))
			{
				return (false, input);
			}
			return (true, input);
		}
	}
}
