using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel;

namespace DAL.Mapping
{
	public class CouncilMap : EntityTypeConfiguration<Council>
	{
		public CouncilMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.ParentId).IsOptional();
			Property(t => t.Name).IsRequired().HasMaxLength(250);
			Property(t => t.ShortName).IsRequired().HasMaxLength(50);
			Property(t => t.AddressId).IsOptional();
			//HasMany(a => a.Persons).WithRequired(p => p.Catalog).HasForeignKey(p => p.CatalogId);
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("Council");
		}
	}
}
