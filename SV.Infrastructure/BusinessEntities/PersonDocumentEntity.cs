using BusinessEntities.BaseBusinessEntities;
using BusinessEntities.Dictionaries;

namespace BusinessEntities
{
	public class PersonDocumentEntity : BaseBusinessEntity
	{
		public int PersonId { get; set; }
		public int DocumentId { get; set; }

		public PersonEntity Person { get; set; }
		public DocumentEntity Document { get; set; }
	}
}
