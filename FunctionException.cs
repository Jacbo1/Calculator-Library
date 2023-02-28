using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
	internal class FunctionException : Exception
	{
		public string FunctionName = "";

		public FunctionException() : base() { }

		public FunctionException(string message) : base(message) { }

		public FunctionException(string funcName, string message) : base(message)
		{
			FunctionName = funcName;
		}

		public FunctionException(string message, Exception inner) : base(message, inner) { }
	}
}
