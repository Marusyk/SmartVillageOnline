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

		public virtual int Id { get; set; }
		public virtual DateTime LastUpdDt { get; set; }
		public virtual string LastUpdUs { get; set; }
	}
}
