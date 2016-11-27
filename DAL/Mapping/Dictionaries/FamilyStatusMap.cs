using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class FamilyStatusMap : EntityTypeConfiguration<FamilyStatus>
	{
		public FamilyStatusMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Persons).WithOptional(p => p.FamilyStatus).HasForeignKey(p => p.FamilyStatusId);
			ToTable("FamilyStatus");
		}
	}
}
