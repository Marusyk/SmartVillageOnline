using AutoMapper;

namespace BLL.Mapping
{
	public static class MappingConfig
	{
		public static void RegisterMapping()
		{
			Mapper.Initialize(config => {
					config.AddProfile(new AutomapperProfile());
			});
		}
	}
}
