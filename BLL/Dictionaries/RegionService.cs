using BusinessEntities.Dictionaries;
using DataModel.Dictionaries;
using DAL.UnitOfWork;

namespace BLL.Dictionaries
{
	public class RegionService : BaseServices<Region, RegionEntity>
	{
		public RegionService(UnitOfWork unitOfWork) : base(unitOfWork) { }
	}
}
