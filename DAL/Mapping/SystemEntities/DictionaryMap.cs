using DataModel.SystemEntities;

namespace DAL.Mapping.SystemEntities
{
	public class DictionaryMap : BaseModelMap<SYS_Dictionary>
	{
		public DictionaryMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.Description).IsRequired().HasMaxLength(250);
			Property(t => t.IsStatic).IsRequired();

			ToTable("SYS_Dictionary");
		}
	}
}
