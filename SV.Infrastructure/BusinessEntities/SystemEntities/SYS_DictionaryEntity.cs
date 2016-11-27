using BusinessEntities.BaseBusinessEntities;

namespace DataModel.SystemEntities
{
	public class SYS_DictionaryEntity : BaseDictionaryEntity
	{
		public string Description { get; set; }
		public bool IsStatic { get; set; }
	}
}
