using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            Property(t => t.CountryId).IsRequired();
            //HasMany(a => a.Districts).WithRequired(p => p.Region).HasForeignKey(p => p.RegionID);
            //HasMany(a => a.Cities).WithRequired(p => p.Region).HasForeignKey(p => p.RegionID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("Region");
        }
    }
}
