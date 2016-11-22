using DataModel.Abstract;
using DAL.Repository;

namespace DAL.UnitOfWork
{
	public interface IUnitOfWork
	{
		void Save();
		IRepository<T> Repository<T>() where T : BaseEntity;
	}
}
