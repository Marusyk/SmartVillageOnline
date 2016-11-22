using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class PassAuthorityMap : EntityTypeConfiguration<PassAuthority>
	{
		public PassAuthorityMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			HasMany(a => a.Persons).WithOptional(p => p.PassAuthority).HasForeignKey(p => p.PassAuthorityId);
			HasMany(a => a.Documents).WithOptional(p => p.PassAuthority).HasForeignKey(p => p.PassAuthorityId);
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("PassAuthority");
		}
	}
}
