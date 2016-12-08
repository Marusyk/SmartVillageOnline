using DataModel;

namespace DAL.Mapping
{
	public class PersonDocumentMap : BaseModelMap<PersonDocument>
	{
		public PersonDocumentMap()
		{
			Property(t => t.PersonId).IsRequired();
			Property(t => t.DocumentId).IsRequired();

			ToTable("PersonDocument");
		}
	}
}
