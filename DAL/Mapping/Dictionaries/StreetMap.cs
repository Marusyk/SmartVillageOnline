using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class StreetMap : EntityTypeConfiguration<Street>
	{
		public StreetMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.StreetTypeId).IsRequired();
			HasMany(a => a.Addresses).WithOptional(p => p.Street).HasForeignKey(p => p.StreetId);
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("Street");
		}
	}
}