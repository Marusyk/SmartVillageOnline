using System;

namespace DataModel.Abstract
{
	public abstract class BaseEntity
	{
		protected BaseEntity()
		{
			LastUpdUs = "SV";
			LastUpdDt = DateTime.Now;
		}

		public int Id { get; set; }
		public DateTime LastUpdDt { get; set; }
		public string LastUpdUs { get; set; }
	}
}
