using BusinessEntities.Dictionaries;
using BLL.Interfaces;
using WebAPI.Infrastructure;

namespace WebAPI.Controllers.Dictionaries
{
	public class AnimalController : BaseApiController<AnimalEntity>
	{
		public AnimalController(IService<AnimalEntity> entityService) : base(entityService) { }
	}
}
