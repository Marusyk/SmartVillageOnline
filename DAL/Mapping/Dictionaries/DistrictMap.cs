using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class DistrictMap : BaseModelMap<District>
	{
		public DistrictMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.RegionId).IsRequired();

			HasMany(a => a.Cities).WithOptional(p => p.District).HasForeignKey(p => p.DistrictId);

			ToTable("District");
		}
	}
}
