using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class CompanyMap : BaseModelMap<Company>
	{
		public CompanyMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.AddressId).IsOptional();
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Employments).WithOptional(p => p.Company).HasForeignKey(p => p.CompanyId);

			ToTable("Company");
		}
	}
}
