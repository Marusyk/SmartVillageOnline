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
			Property(t => t.Description).HasMaxLength(500);
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("Employment");
		}
	}
}
