using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities.Dictionaries;
using Infrastructure.Interfaces;
using WebAPI.Infrastructure;

namespace WebAPI.Controllers.Dictionaries {
	public class CountryController : BaseApiController<CountryEntity>
	{
		public CountryController(IServices<CountryEntity> entityServices) : base(entityServices) { }
	}
}