using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class StreetMap : EntityTypeConfiguration<Street>
    {
        public StreetMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            Property(t => t.StreetTypeID).IsRequired();
            HasMany(a => a.Addresses).WithOptional(p => p.Street).HasForeignKey(p => p.StreetID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("Street");
        }
    }
}