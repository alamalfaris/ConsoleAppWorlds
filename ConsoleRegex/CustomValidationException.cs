using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRegex
{
	[Serializable]
	public class CustomValidationException : Exception
	{
		public CustomValidationException(string message) : base(message) { }
		protected CustomValidationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
