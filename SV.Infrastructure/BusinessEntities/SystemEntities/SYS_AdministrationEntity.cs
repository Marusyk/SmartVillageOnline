using System;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.SystemEntities
{
	public class SYS_AdministrationEntity : BaseDictionaryEntity
	{
		public string Description { get; set; }
		public string DataBaseName { get; set; }
		public string SVVersion { get; set; }
		public string DBVersion { get; set; }
		public Guid DataBaseGuid { get; set; }
	}
}
