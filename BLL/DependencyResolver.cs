﻿using System.ComponentModel.Composition;
using BusinessEntities.Dictionaries;
using DependencyResolution.Interfaces;
using BLL.Dictionaries;
using BLL.Interfaces;

namespace BLL
{
	[Export(typeof(IComponent))]
	public class DependencyResolver : IComponent
	{
		public void SetUp(IRegisterComponent registerComponent)
		{
			registerComponent.RegisterType(typeof(IService<AnimalEntity>), typeof(AnimalService));
			//registerComponent.RegisterType(typeof(IService<CountryEntity>), typeof(CountryService));
			//registerComponent.RegisterType(typeof(IService<RegionEntity>), typeof(RegionService));

			
		}
	}
}