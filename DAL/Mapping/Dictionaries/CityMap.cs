using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class CityMap : BaseModelMap<City>
	{
		public CityMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CityTypeId).IsRequired();
			Property(t => t.DistrictId).IsOptional();
			Property(t => t.RegionId).IsRequired();

			HasMany(a => a.Addresses).WithRequired(p => p.City).HasForeignKey(p => p.CityId);
			HasMany(a => a.Institution).WithRequired(p => p.City).HasForeignKey(p => p.CityId);

			ToTable("City");
		}
	}
}
