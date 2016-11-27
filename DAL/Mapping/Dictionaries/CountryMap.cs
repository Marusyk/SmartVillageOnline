using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class CountryMap : EntityTypeConfiguration<Country>
	{
		public CountryMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Regions).WithRequired(p => p.Country).HasForeignKey(p => p.CountryId);
			HasMany(a => a.Persons).WithOptional(p => p.Citizenship).HasForeignKey(p => p.CitizenshipId);

			ToTable("Country");
		}
	}
}
