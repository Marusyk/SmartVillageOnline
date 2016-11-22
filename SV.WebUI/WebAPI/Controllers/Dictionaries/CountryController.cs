using BusinessEntities.Dictionaries;
using BLL.Interfaces;
using WebAPI.Infrastructure;

namespace WebAPI.Controllers.Dictionaries
{
	public class CountryController : BaseApiController<CountryEntity>
	{
		public CountryController(IService<CountryEntity> entityService) : base(entityService) { }
	}
}