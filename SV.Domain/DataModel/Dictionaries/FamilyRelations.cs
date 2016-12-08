using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class FamilyRelations : BaseDictionary
	{
		//Navigation
		public virtual ICollection<People> Peoples { get; set; }
	}
}
