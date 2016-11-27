namespace BusinessEntities.BaseBusinessEntities
{
	public class BaseBusinessCouncilEntity : BaseBusinessEntity
	{
		public int CouncilId { get; set; }

		public virtual CouncilEntity Council { get; set; }
	}
}
