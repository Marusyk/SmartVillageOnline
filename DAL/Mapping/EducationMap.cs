using DataModel;

namespace DAL.Mapping
{
	public class EducationMap : BaseModelMap<Education>
	{
		public EducationMap()
		{
			Property(t => t.PersonId).IsRequired();
			Property(t => t.InstitutionId).IsRequired();
			Property(t => t.SpecialitiesId).IsOptional();
			Property(t => t.EducationDegreeId).IsOptional();
			Property(t => t.StartYear).IsOptional();
			Property(t => t.EndYear).IsOptional();
			Property(t => t.DocumentId).IsOptional();
			Property(t => t.Description).HasMaxLength(500);

			ToTable("Education");
		}
	}
}
