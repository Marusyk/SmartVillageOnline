using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class FamilyRelations : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<People> Peoples { get; set; }
    }
}
