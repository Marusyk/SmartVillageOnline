using System;
using DataModel.Abstract;
using DataModel.Entities.Dictionaries;

namespace DataModel.Entities
{
    public class Employment : BaseEntity
    {
        public int PersonID { get; set; }

        public int? ActivityTypesID { get; set; }

        public int? CompanyID { get; set; }

        public int? PositionID { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public bool IsCurrent { get; set; }

        public string Description { get; set; }

        //FK
        public virtual Person Person { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        public virtual Company Company { get; set; }
        public virtual Position Position { get; set; }
    }
}
