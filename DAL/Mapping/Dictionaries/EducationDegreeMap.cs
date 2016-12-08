using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class EducationDegreeMap : BaseModelMap<EducationDegree>
	{
		public EducationDegreeMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(p => p.Educations).WithOptional(p => p.EducationDegree).HasForeignKey(p => p.EducationDegreeId);

			ToTable("EducationDegree");
		}
	}
}
