using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel;

namespace DAL.Mapping
{
	public class DocumentMap : EntityTypeConfiguration<Document>
	{
		public DocumentMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.DocumentTypeId).IsOptional();
			Property(t => t.Name).IsRequired().HasMaxLength(100);
			Property(t => t.PassAuthorityId).IsOptional();
			Property(t => t.Number).HasMaxLength(20);
			Property(t => t.Code).HasMaxLength(10);
			Property(t => t.State).IsRequired();
			Property(t => t.CouncilId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Educations).WithOptional(p => p.Document).HasForeignKey(p => p.DocumentId);
			HasMany(a => a.PersonDocuments).WithRequired(p => p.Document).HasForeignKey(p => p.DocumentId);

			ToTable("Document");
		}
	}
}
