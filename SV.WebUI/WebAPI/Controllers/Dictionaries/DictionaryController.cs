using BLL.Interfaces;
using BusinessEntities.SystemEntities;
using WebAPI.Infrastructure;

namespace WebAPI.Controllers.Dictionaries
{
	public class DictionaryController : BaseApiController<SYS_DictionaryEntity>
	{
		public DictionaryController(IService<SYS_DictionaryEntity> entityService) : base(entityService) { }
	}
}