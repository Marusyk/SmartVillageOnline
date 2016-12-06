using DAL.Repository;
using DependencyResolution.Interfaces;
using System.ComponentModel.Composition;

namespace DAL
{
	[Export(typeof(IComponent))]
	internal class DepenencyResolver : IComponent
	{
		public void SetUp(IRegisterComponent registerComponent)
		{
			registerComponent.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));
		}
	}
}
