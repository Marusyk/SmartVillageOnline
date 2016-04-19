using System.Collections.Generic;
using System.Runtime.Serialization;
using Domain.Abstract;

namespace Domain.Entities.Dictionaries
{
    public class EducationDegree : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
