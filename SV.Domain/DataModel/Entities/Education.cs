﻿using DataModel.Entities.Abstract;
using DataModel.Entities.Dictionaries;

namespace DataModel.Entities
{
    public class Education : BaseEntity
    {
        public int PersonID { get; set; }

        public int InstitutionID { get; set; }

        public int? SpecialitiesID { get; set; }

        public int? EducationDegreeID { get; set; }

        public int? StartYear { get; set; }

        public int? EndYear { get; set; }

        public int? DocumentID { get; set; }

        public string Description { get; set; }

        //FK
        public virtual Person Person { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual EducationDegree EducationDegree { get; set; }
        public virtual Document Document { get; set; }
    }
}
