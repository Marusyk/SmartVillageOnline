using BusinessEntities.Dictionaries;
using BLL.Interfaces;
using WebAPI.Infrastructure;

namespace WebAPI.Controllers.Dictionaries
{
	public class RegionController : BaseApiController<RegionEntity>
	{
		public RegionController(IService<RegionEntity> entityService) : base(entityService) { }
	}
}