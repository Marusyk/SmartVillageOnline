using System;
using DependencyResolution.Interfaces;
using Microsoft.Practices.Unity;

namespace DependencyResolution.Implementations
{
	internal class RegisterComponent : IRegisterComponent
	{
		private readonly IUnityContainer _container;

		public RegisterComponent(IUnityContainer container)
		{
			_container = container;
		}

		public void RegisterType<TFrom, TTo>(bool withInterception = false) where TTo : TFrom
		{
			if (withInterception)
			{
				// register with interception 
			}
			else
			{
				_container.RegisterType<TFrom, TTo>();
			}
		}

		public void RegisterType(Type typeFrom, Type typeTo)
		{
			_container.RegisterType(typeFrom, typeTo);
		}

		public void RegisterTypeWithControlledLifeTime<TFrom, TTo>(bool withInterception = false) where TTo : TFrom
		{
			_container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
		}
	}
}
