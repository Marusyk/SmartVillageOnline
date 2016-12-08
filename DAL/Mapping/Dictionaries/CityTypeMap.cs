using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class CityTypeMap : BaseModelMap<CityType>
	{
		public CityTypeMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(a => a.Cities).WithRequired(p => p.CityType).HasForeignKey(p => p.CityTypeId);

			ToTable("CityType");
		}
	}
}

