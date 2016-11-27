using System;
using DataModel.Abstract;

namespace DataModel.SystemEntities
{
	public class SYS_Administration : BaseDictionary
	{
		public string Description { get; set; }
		public string DataBaseName { get; set; }
		public string SVVersion { get; set; }
		public string DBVersion { get; set; }
		public Guid DataBaseGuid { get; set; }
	}
}
