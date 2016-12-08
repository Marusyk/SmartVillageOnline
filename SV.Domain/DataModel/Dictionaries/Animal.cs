using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Animal : BaseDictionary
	{
		public virtual int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }
	}
}
