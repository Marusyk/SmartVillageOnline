using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class StreetTypeMap : EntityTypeConfiguration<StreetType>
    {
        public StreetTypeMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            HasMany(a => a.Streets).WithRequired(p => p.StreetType).HasForeignKey(p => p.StreetTypeID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("StreetType");
        }
    }
}