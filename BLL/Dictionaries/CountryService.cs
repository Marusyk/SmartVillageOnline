using BusinessEntities.Dictionaries;
using BusinessEntities.Dictionaries;
using DAL.UnitOfWork;

namespace BLL.Dictionaries
{
	public class CountryService : BaseServices<Country, CountryEntity>
	{
		public CountryService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
	}
}
