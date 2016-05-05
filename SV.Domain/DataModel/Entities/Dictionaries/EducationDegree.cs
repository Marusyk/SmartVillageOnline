using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class EducationDegree : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
