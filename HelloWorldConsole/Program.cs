using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;
using ServicesLibrary;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace HelloWorldConsole
{
	static class Program
	{
		static void Main( string[] args )
		{
			var unityContainer = UnityHelper.GetUnityContainer();
			var service = unityContainer.Resolve<HelloWorldService>();
			service.HelloWorld();
		}
	}
}
