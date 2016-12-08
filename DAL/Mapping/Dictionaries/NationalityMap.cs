using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class NationalityMap : BaseModelMap<Nationality>
	{
		public NationalityMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(a => a.Persons).WithOptional(p => p.Nationality).HasForeignKey(p => p.NationalityId);

			ToTable("Nationality");
		}
	}
}
