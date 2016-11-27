using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel;

namespace DAL.Mapping
{
	public class PersonDocumentMap : EntityTypeConfiguration<PersonDocument>
	{
		public PersonDocumentMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.PersonId).IsRequired();
			Property(t => t.DocumentId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			ToTable("PersonDocument");
		}
	}
}
