using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class AnimalMap : BaseModelMap<Animal>
	{
		public AnimalMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			ToTable("Animal");
		}
	}
}
