using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyResolution.Interfaces;
using DataModel.Abstract;
using Infrastructure.Interfaces;

namespace Infrastructure
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType(typeof(IServices<>), typeof(AnimalService));
        }
    }
}
