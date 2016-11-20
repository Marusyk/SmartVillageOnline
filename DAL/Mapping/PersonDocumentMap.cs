using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Entities;

namespace DataModel.Mapping
{
    public class PersonDocumentMap : EntityTypeConfiguration<PersonDocument>
    {
        public PersonDocumentMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.DocumentID).IsRequired();
            Property(t => t.PersonID).IsRequired();
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("PersonDocument");
        }
    }
}
