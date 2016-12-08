using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class RegionMap : BaseModelMap<Region>
	{
		public RegionMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CountryId).IsRequired();

			HasMany(a => a.Districts).WithRequired(p => p.Region).HasForeignKey(p => p.RegionId);
			HasMany(a => a.Cities).WithRequired(p => p.Region).HasForeignKey(p => p.RegionId);

			ToTable("Region");
		}
	}
}
