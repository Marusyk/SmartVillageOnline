using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class CityMap : EntityTypeConfiguration<City>
	{
		public CityMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CityTypeId).IsRequired();
			Property(t => t.DistrictId).IsOptional();
			Property(t => t.RegionId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Addresses).WithRequired(p => p.City).HasForeignKey(p => p.CityId);
			HasMany(a => a.Institution).WithRequired(p => p.City).HasForeignKey(p => p.CityId);
			ToTable("City");
		}
	}
}
