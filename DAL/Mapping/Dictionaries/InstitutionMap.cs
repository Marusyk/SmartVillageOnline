using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class InstitutionMap : BaseModelMap<Institution>
	{
		public InstitutionMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CityId).IsRequired();
			Property(t => t.CouncilId).IsRequired();

			HasMany(p => p.Educations).WithRequired(p => p.Institution).HasForeignKey(p => p.InstitutionId);

			ToTable("Institution");
		}
	}
}
