using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class DocumentTypeMap : BaseModelMap<DocumentType>
	{
		public DocumentTypeMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.Code).HasMaxLength(20);
			Property(t => t.CouncilId).IsRequired();

			HasMany(p => p.Documents).WithOptional(p => p.DocumentType).HasForeignKey(p => p.DocumentTypeId);

			ToTable("DocumentType");
		}
	}
}
