using System.ComponentModel.Composition;
using DAL.Repository;
using DAL.UnitOfWork;
using DependencyResolution.Interfaces;

namespace DataModel
{
	[Export(typeof(IComponent))]
	internal class DepenencyResolver : IComponent
	{
		public void SetUp(IRegisterComponent registerComponent)
		{
			registerComponent.RegisterType<IUnitOfWork, UnitOfWork>();
			registerComponent.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));
		}
	}
}
