using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using ServicesLibrary;

namespace UnitTests
{
	[TestFixture]
    public class HelloWorldServiceTest
    {
		[Test]
		public void HelloWorld_VerifyExecutedTest()
		{
			var outputMock = new Mock<IWritable>();
			var service = new HelloWorldService(outputMock.Object);
			service.HelloWorld();

			outputMock.Verify( output => output.Write("Hello World"), Times.Once );
			outputMock.VerifyNoOtherCalls();
		}
	}
}
