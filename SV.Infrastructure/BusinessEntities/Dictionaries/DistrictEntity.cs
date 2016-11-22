using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class DistrictEntity : BaseDictionaryEntity
	{
		public int RegionId { get; set; }
		//FK
		public virtual RegionEntity Region { get; set; }
	}
}
