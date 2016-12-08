using DataModel.SystemEntities;

namespace DAL.Mapping.SystemEntities
{
	public class AdministrationMap : BaseModelMap<SYS_Administration>
	{
		public AdministrationMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.Description).IsRequired().HasMaxLength(250);
			Property(t => t.DataBaseName).IsOptional().HasMaxLength(100);
			Property(t => t.SVVersion).IsRequired().HasMaxLength(50);
			Property(t => t.DBVersion).IsRequired().HasMaxLength(50);
			Property(t => t.DataBaseGuid).IsOptional();

			ToTable("SYS_Administration");
		}
	}
}
