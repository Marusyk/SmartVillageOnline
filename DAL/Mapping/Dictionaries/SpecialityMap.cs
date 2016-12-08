using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class SpecialityMap : BaseModelMap<Speciality>
	{
		public SpecialityMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			HasMany(p => p.Educations).WithOptional(p => p.Speciality).HasForeignKey(p => p.SpecialitiesId);

			ToTable("Speciality");
		}
	}
}
