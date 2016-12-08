using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class FamilyStatusMap : BaseModelMap<FamilyStatus>
	{
		public FamilyStatusMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(a => a.Persons).WithOptional(p => p.FamilyStatus).HasForeignKey(p => p.FamilyStatusId);

			ToTable("FamilyStatus");
		}
	}
}
