namespace DataModel.Abstract
{
	public abstract class BaseDictionaryCouncil : BaseDictionary
	{
		public virtual int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }
	}
}
