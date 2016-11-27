namespace DataModel.Abstract
{
	public abstract class BaseDictionaryCouncil : BaseDictionary
	{
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }
	}
}
