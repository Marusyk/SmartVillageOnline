using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class ActivityTypeMap : BaseModelMap<ActivityType>
	{
		public ActivityTypeMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Employments).WithOptional(p => p.ActivityType).HasForeignKey(p => p.ActivityTypesId);

			ToTable("ActivityType");
		}
	}
}
