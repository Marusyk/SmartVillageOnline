using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class RegionMap : EntityTypeConfiguration<Region>
	{
		public RegionMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CountryId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Districts).WithRequired(p => p.Region).HasForeignKey(p => p.RegionId);
			HasMany(a => a.Cities).WithRequired(p => p.Region).HasForeignKey(p => p.RegionId);
			ToTable("Region");
		}
	}
}
