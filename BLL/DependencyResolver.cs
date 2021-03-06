﻿using System.ComponentModel.Composition;
using BusinessEntities.Dictionaries;
using DependencyResolution.Interfaces;
using BLL.Dictionaries;
using BLL.Interfaces;
using BLL.Mapping;
using BusinessEntities.SystemEntities;
using DAL.UnitOfWork;

namespace BLL
{
	[Export(typeof(IComponent))]
	public class DependencyResolver : IComponent
	{
		public void SetUp(IRegisterComponent registerComponent)
		{
			MappingConfig.RegisterMapping();

			registerComponent.RegisterType(typeof(IService<SYS_DictionaryEntity>), typeof(DictionaryService));

			registerComponent.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork));
			registerComponent.RegisterType(typeof(IService<AnimalEntity>), typeof(AnimalService));
			registerComponent.RegisterType(typeof(IService<CountryEntity>), typeof(CountryService));
			registerComponent.RegisterType(typeof(IService<RegionEntity>), typeof(RegionService));
		}
	}
}
