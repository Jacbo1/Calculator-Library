using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
	internal class FractionDoubleParsingException : Exception
	{
		public FractionDoubleParsingException() : base("Number too small or large for Fraction.") { }

		public FractionDoubleParsingException(string message) : base(message) { }

		public FractionDoubleParsingException(string message, Exception inner) : base(message, inner) { }
	}
}
