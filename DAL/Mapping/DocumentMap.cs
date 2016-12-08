using DataModel;

namespace DAL.Mapping
{
	public class DocumentMap : BaseModelMap<Document>
	{
		public DocumentMap()
		{
			Property(t => t.DocumentTypeId).IsOptional();
			Property(t => t.Name).IsRequired().HasMaxLength(100);
			Property(t => t.PassAuthorityId).IsOptional();
			Property(t => t.Number).HasMaxLength(20);
			Property(t => t.Code).HasMaxLength(10);
			Property(t => t.State).IsRequired();
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Educations).WithOptional(p => p.Document).HasForeignKey(p => p.DocumentId);
			HasMany(a => a.PersonDocuments).WithRequired(p => p.Document).HasForeignKey(p => p.DocumentId);

			ToTable("Document");
		}
	}
}
