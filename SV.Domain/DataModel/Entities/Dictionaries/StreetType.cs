using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Entities.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class StreetType : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Street> Streets { get; set; }
    }
}
