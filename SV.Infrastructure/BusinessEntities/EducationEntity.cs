using BusinessEntities.BaseBusinessEntities;
using BusinessEntities.Dictionaries;

namespace BusinessEntities
{
	public class EducationEntity : BaseBusinessEntity
	{
		public int PersonId { get; set; }
		public int InstitutionId { get; set; }
		public int? SpecialitiesId { get; set; }
		public int? EducationDegreeId { get; set; }
		public int? StartYear { get; set; }
		public int? EndYear { get; set; }
		public int? DocumentId { get; set; }
		public string Description { get; set; }

		public PersonEntity Person { get; set; }
		public InstitutionEntity Institution { get; set; }
		public SpecialityEntity Speciality { get; set; }
		public EducationDegreeEntity EducationDegree { get; set; }
		public DocumentEntity Document { get; set; }
	}
}
