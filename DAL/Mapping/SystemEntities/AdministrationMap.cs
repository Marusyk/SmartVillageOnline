using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.SystemEntities;

namespace DAL.Mapping.SystemEntities
{
	public class AdministrationMap : EntityTypeConfiguration<SYS_Administration>
	{
		public AdministrationMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.Description).IsRequired().HasMaxLength(250);
			Property(t => t.DataBaseName).IsOptional().HasMaxLength(100);
			Property(t => t.SVVersion).IsRequired().HasMaxLength(50);
			Property(t => t.DBVersion).IsRequired().HasMaxLength(50);
			Property(t => t.DataBaseGuid).IsOptional();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			ToTable("SYS_Administration");
		}
	}
}
