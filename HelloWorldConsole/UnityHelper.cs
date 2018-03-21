using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace HelloWorldConsole
{
	static class UnityHelper
	{
		private static readonly Lazy<IUnityContainer> _unityContainer = new Lazy<IUnityContainer>( () =>
		{
			var container = new UnityContainer();
			container.LoadConfiguration();
			return container;
		} );

		public static IUnityContainer GetUnityContainer()
		{
			return _unityContainer.Value;
		}
	}
}
