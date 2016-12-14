using BusinessEntities.SystemEntities;
using DataModel.SystemEntities;
using DAL.UnitOfWork;

namespace BLL.Dictionaries
{
	public class DictionaryService : BaseServices<SYS_Dictionary, SYS_DictionaryEntity>
	{
		public DictionaryService(IUnitOfWork unitOfWork) : base(unitOfWork) { }
	}
}
