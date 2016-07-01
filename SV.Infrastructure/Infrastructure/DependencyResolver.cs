using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Dictionaries;
using DependencyResolution.Interfaces;
using Infrastructure.Dictionaries;
using Infrastructure.Interfaces;

namespace Infrastructure
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType(typeof(IServices<AnimalEntity>), typeof(AnimalService));
			registerComponent.RegisterType(typeof(IServices<CountryEntity>), typeof(CountryService));
			registerComponent.RegisterType(typeof(IServices<RegionEntity>), typeof(RegionService));
		}
    }
}
