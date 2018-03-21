using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicesLibrary;

namespace HelloWorldConsole
{
	// ReSharper disable once UnusedMember.Global
	class ConsoleWriter : IWritable
	{
		public void Write(string message)
		{
			Console.WriteLine(message);
		}
	}
}
