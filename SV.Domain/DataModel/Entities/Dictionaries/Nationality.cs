using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Entities.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class Nationality : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Person> Persons { get; set; }
    }
}
