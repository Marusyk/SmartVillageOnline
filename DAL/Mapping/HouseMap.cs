using DataModel;

namespace DAL.Mapping
{
	class HouseMap : BaseModelMap<House>
	{
		public HouseMap()
		{
			Property(t => t.HouseNr).IsRequired().HasMaxLength(10);
			Property(t => t.KadastrNr).IsOptional().HasMaxLength(30);
			Property(t => t.BuildNr).IsRequired().HasMaxLength(10);
			Property(t => t.AddressId).IsRequired();
			Property(t => t.PhoneNr).IsOptional().HasMaxLength(12);
			Property(t => t.PhoneCode).IsOptional().HasMaxLength(5);
			Property(t => t.FaxNr).IsOptional().HasMaxLength(12);
			Property(t => t.Year).IsOptional();
			Property(t => t.Code).IsOptional().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Peoples).WithRequired(p => p.Houses).HasForeignKey(p => p.HouseId);

			ToTable("House");
		}
	}
}
