using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class Speciality : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
