using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class Institution : BaseDictionary
    {
        public int CityID { get; set; }

        //FK
        public virtual City City { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Education> Educations { get; set; }
    }
}
