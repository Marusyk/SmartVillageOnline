using System;

namespace BusinessEntities.BaseBusinessEntities
{
	public class BaseBusinessEntity
	{
		protected BaseBusinessEntity()
		{
			LastUpdUs = "SV";
			LastUpdDt = DateTime.Now;
		}

		public int Id { get; set; }
		public DateTime LastUpdDt { get; set; }
		public string LastUpdUs { get; set; }
	}
}
