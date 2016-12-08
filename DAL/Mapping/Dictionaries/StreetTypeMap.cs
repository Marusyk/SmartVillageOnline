using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class StreetTypeMap : BaseModelMap<StreetType>
	{
		public StreetTypeMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(a => a.Streets).WithRequired(p => p.StreetType).HasForeignKey(p => p.StreetTypeId);

			ToTable("StreetType");
		}
	}
}