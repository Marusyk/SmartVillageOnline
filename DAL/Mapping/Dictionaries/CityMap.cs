using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            Property(t => t.CityTypeID).IsRequired();
            Property(t => t.RegionID).IsRequired();
            HasMany(a => a.Addresses).WithRequired(p => p.City).HasForeignKey(p => p.CityID);
            HasMany(a => a.Institution).WithRequired(p => p.City).HasForeignKey(p => p.CityID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("City");
        }
    }
}
