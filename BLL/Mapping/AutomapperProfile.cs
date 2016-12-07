using AutoMapper;
using BusinessEntities;
using BusinessEntities.Dictionaries;
using DataModel;
using DataModel.Dictionaries;

namespace BLL.Mapping
{
	public class AutomapperProfile : Profile
	{
		public AutomapperProfile()
		{
			CreateMap<Animal, AnimalEntity>();
			CreateMap<Council, CouncilEntity>();
		}
	}
}
