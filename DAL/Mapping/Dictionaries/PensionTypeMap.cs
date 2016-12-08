using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class PensionTypeMap : BaseModelMap<PensionType>
	{
		public PensionTypeMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			ToTable("PensionType");
		}
	}
}
