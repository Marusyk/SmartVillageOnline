using DataModel;

namespace BusinessEntities.BaseBusinessEntities
{
	public abstract class BaseDictionaryCouncilEntity : BaseDictionaryEntity
	{
		public int CouncilId { get; set; }

		public CouncilEntity Council { get; set; }
	}
}
