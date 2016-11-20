using DataModel.Entities.Abstract;
using DataModel.Repository;

namespace DataModel.UnitOfWork
{
	public interface IUnitOfWork
	{
		void Save();
		IRepository<T> Repository<T>() where T : BaseEntity;
	}
}
