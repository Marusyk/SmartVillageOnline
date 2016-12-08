using DataModel;

namespace DAL.Mapping
{
	public class EmploymentMap : BaseModelMap<Employment>
	{
		public EmploymentMap()
		{
			Property(t => t.PersonId).IsRequired();
			Property(t => t.ActivityTypesId).IsOptional();
			Property(t => t.CompanyId).IsOptional();
			Property(t => t.PositionId).IsOptional();
			Property(t => t.DateStart).IsOptional();
			Property(t => t.DateEnd).IsOptional();
			Property(t => t.IsCurrent).IsRequired();
			Property(t => t.Description).IsOptional().HasMaxLength(500);

			ToTable("Employment");
		}
	}
}
