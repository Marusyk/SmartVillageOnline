using System.ComponentModel.Composition;
using DataModel.Repository;
using DataModel.UnitOfWork;
using DependencyResolution.Interfaces;

namespace DataModel
{
    [Export(typeof(IComponent))]
    internal class DepenencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IUnitOfWork, UnitOfWork.UnitOfWork>();
            registerComponent.RegisterType(typeof(IRepository<>), typeof(EFRepository<>));
        }
    }
}
