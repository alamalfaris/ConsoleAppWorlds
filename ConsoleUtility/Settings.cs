using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtility
{
	public class Settings
	{
		public int KeyOne { get; set; }
		public bool KeyTwo { get; set; }
		public NestedSettings KeyThree { get; set; } = null!;
	}
}
