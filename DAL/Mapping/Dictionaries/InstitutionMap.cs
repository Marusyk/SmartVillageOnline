using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class InstitutionMap : EntityTypeConfiguration<Institution>
	{
		public InstitutionMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CityId).IsRequired();
			Property(t => t.CouncilId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(p => p.Educations).WithRequired(p => p.Institution).HasForeignKey(p => p.InstitutionId);
			ToTable("Institution");
		}
	}
}
