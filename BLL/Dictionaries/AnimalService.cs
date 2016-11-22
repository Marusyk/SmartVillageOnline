using BusinessEntities.Dictionaries;
using DataModel.Dictionaries;
using DAL.UnitOfWork;

namespace BLL.Dictionaries
{
	public class AnimalService : BaseServices<Animal, AnimalEntity>
	{
		public AnimalService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
	}
}
