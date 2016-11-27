using BusinessEntities.BaseBusinessEntities;
using DataModel.Dictionaries;

namespace DataModel
{
	public class PersonDocumentEntity : BaseBusinessEntity
	{
		public int PersonId { get; set; }
		public int DocumentId { get; set; }

		public virtual PersonEntity Person { get; set; }
		public virtual DocumentEntity Document { get; set; }
	}
}
