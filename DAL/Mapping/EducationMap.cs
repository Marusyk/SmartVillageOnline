using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel;

namespace DAL.Mapping
{
	public class EducationMap : EntityTypeConfiguration<Education>
	{
		public EducationMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.PersonId).IsRequired();
			Property(t => t.InstitutionId).IsRequired();
			Property(t => t.SpecialitiesId).IsOptional();
			Property(t => t.EducationDegreeId).IsOptional();
			Property(t => t.StartYear).IsOptional();
			Property(t => t.EndYear).IsOptional();
			Property(t => t.DocumentId).IsOptional();
			Property(t => t.Description).HasMaxLength(500);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			ToTable("Education");
		}
	}
}
