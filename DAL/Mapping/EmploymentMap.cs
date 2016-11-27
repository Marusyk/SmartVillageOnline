using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel;

namespace DAL.Mapping
{
	public class EmploymentMap : EntityTypeConfiguration<Employment>
	{
		public EmploymentMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.PersonId).IsRequired();
			Property(t => t.ActivityTypesId).IsOptional();
			Property(t => t.CompanyId).IsOptional();
			Property(t => t.PositionId).IsOptional();
			Property(t => t.DateStart).IsOptional();
			Property(t => t.DateEnd).IsOptional();
			Property(t => t.IsCurrent).IsRequired();
			Property(t => t.Description).IsOptional().HasMaxLength(500);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			ToTable("Employment");
		}
	}
}
