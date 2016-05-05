using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class Position : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Employment> Employments { get; set; }
    }
}
