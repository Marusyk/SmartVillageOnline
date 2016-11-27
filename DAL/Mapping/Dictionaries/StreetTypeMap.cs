using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class StreetTypeMap : EntityTypeConfiguration<StreetType>
	{
		public StreetTypeMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Streets).WithRequired(p => p.StreetType).HasForeignKey(p => p.StreetTypeId);

			ToTable("StreetType");
		}
	}
}