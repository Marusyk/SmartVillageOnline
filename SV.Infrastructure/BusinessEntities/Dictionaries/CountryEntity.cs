using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.BaseBusinessEntities;
using System.Runtime.Serialization;

namespace BusinessEntities.Dictionaries {
	public class CountryEntity : BaseDictionaryEntity
	{
		[IgnoreDataMember]
		public virtual ICollection<RegionEntity> Regions { get; set; }
	}
}
