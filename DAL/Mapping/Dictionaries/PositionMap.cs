using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class PositionMap : BaseModelMap<Position>
	{
		public PositionMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Employments).WithOptional(p => p.Position).HasForeignKey(p => p.PositionId);

			ToTable("Position");
		}
	}
}
