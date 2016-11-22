using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class SpecialityMap : EntityTypeConfiguration<Speciality>
	{
		public SpecialityMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			HasMany(p => p.Educations).WithOptional(p => p.Speciality).HasForeignKey(p => p.SpecialitiesId);
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("Speciality");
		}
	}
}
