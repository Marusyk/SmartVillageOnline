using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Education : BaseEntity
	{
		public int PersonId { get; set; }
		public int InstitutionId { get; set; }
		public int? SpecialitiesId { get; set; }
		public int? EducationDegreeId { get; set; }
		public int? StartYear { get; set; }
		public int? EndYear { get; set; }
		public int? DocumentId { get; set; }
		public string Description { get; set; }

		//FK
		public virtual Person Person { get; set; }
		public virtual Institution Institution { get; set; }
		public virtual Speciality Speciality { get; set; }
		public virtual EducationDegree EducationDegree { get; set; }
		public virtual Document Document { get; set; }
	}
}
