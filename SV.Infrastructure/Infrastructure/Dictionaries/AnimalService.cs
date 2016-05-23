using BusinessEntities.Dictionaries;
using DataModel.Entities.Dictionaries;
using DataModel.UnitOfWork;

namespace Infrastructure.Dictionaries
{
    public class AnimalService : BaseServices<AnimalEntity, Animal>
    {
        public AnimalService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
