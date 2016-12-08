using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Material : BaseDictionary
	{
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }
	}
}
