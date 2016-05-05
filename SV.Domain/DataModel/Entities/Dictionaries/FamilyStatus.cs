﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class FamilyStatus : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<Person> Persons { get; set; }
    }
}
