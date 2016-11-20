using DataModel.Abstract;

namespace DataModel.SystemEntities
{
	public class SYS_Dictionary : BaseDictionary
	{
		public string Description { get; set; }
		public bool IsStatic { get; set; }
	}
}
