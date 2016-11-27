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
			Property(t => t.EDRPOUCode).IsOptional();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.ActivityTypes).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			ToTable("Council");
		}
	}
}
