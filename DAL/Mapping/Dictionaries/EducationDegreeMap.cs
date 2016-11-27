using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class EducationDegreeMap : EntityTypeConfiguration<EducationDegree>
	{
		public EducationDegreeMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(p => p.Educations).WithOptional(p => p.EducationDegree).HasForeignKey(p => p.EducationDegreeId);
			ToTable("EducationDegree");
		}
	}
}
