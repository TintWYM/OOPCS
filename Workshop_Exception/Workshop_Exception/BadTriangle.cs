using System;
namespace Workshop_Exception
{
	public class BadTriangle : Exception
	{
		public BadTriangle() : base() { }

		public BadTriangle(string message) : base(message) { }
	}
}

