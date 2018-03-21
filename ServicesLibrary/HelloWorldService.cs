using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary
{
    public class HelloWorldService
    {
	    private readonly IWritable _output;
		public HelloWorldService( IWritable output )
		{
			_output = output;
		}
		public void HelloWorld()
		{
			_output.Write("Hello World");
		}
    }
}
