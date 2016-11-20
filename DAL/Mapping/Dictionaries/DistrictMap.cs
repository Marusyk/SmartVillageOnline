using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class DistrictMap : EntityTypeConfiguration<District>
    {
        public DistrictMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            Property(t => t.RegionID).IsRequired();
            HasMany(a => a.Cities).WithOptional(p => p.District).HasForeignKey(p => p.DistrictID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("District");
        }
    }
}
