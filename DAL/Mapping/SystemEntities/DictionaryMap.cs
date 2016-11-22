using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.SystemEntities;

namespace DAL.Mapping.SystemEntities
{
	public class DictionaryMap : EntityTypeConfiguration<SYS_Dictionary>
	{
		public DictionaryMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.Description).IsRequired().HasMaxLength(250);
			Property(t => t.IsStatic).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("SYS_Dictionary");
		}
	}
}
