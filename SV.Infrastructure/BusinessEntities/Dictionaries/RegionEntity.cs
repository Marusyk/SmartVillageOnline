using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.BaseBusinessEntities;
using DataModel.Entities.Dictionaries;

namespace BusinessEntities.Dictionaries {
	public class RegionEntity : BaseDictionaryEntity
	{
		public int CountryId { get; set; }
		//public virtual CountryEntity Country { get; set; }
	}
}
