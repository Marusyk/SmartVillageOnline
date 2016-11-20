using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class PersonDocument : BaseEntity
	{
		public int PersonId { get; set; }
		public int DocumentId { get; set; }

		//FK
		public virtual Person Person { get; set; }
		public virtual Document Document { get; set; }
	}
}
