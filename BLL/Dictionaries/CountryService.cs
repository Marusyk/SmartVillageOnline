using BusinessEntities.Dictionaries;
using DataModel.Dictionaries;
using DAL.UnitOfWork;

namespace BLL.Dictionaries
{
	public class CountryService : BaseServices<Country, CountryEntity>
	{
		public CountryService(UnitOfWork unitOfWork) : base(unitOfWork) { }
	}
}
