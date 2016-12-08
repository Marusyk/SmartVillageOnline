using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class CountryMap : BaseModelMap<Country>
	{
		public CountryMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(a => a.Regions).WithRequired(p => p.Country).HasForeignKey(p => p.CountryId);
			HasMany(a => a.Persons).WithOptional(p => p.Citizenship).HasForeignKey(p => p.CitizenshipId);

			ToTable("Country");
		}
	}
}
