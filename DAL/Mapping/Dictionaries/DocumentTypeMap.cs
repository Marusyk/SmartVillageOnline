using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class DocumentTypeMap : EntityTypeConfiguration<DocumentType>
	{
		public DocumentTypeMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.Code).HasMaxLength(20);
			Property(t => t.CouncilId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(p => p.Documents).WithOptional(p => p.DocumentType).HasForeignKey(p => p.DocumentTypeId);
			ToTable("DocumentType");
		}
	}
}
