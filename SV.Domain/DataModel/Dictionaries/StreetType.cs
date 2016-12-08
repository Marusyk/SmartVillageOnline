using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class StreetType : BaseDictionary
	{
		//Navigation
		public virtual ICollection<Street> Streets { get; set; }
	}
}
