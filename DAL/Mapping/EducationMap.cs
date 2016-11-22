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
			Property(t => t.Description).HasMaxLength(500);
			Property(t => t.LastUpdUs).HasMaxLength(50);
			ToTable("Education");
		}
	}
}
