namespace DataModel.Abstract
{
	public class BaseEntityCouncil : BaseEntity
	{
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }
	}
}
