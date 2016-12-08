using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class StreetMap : BaseModelMap<Street>
	{
		public StreetMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.StreetTypeId).IsRequired();
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Addresses).WithOptional(p => p.Street).HasForeignKey(p => p.StreetId);

			ToTable("Street");
		}
	}
}