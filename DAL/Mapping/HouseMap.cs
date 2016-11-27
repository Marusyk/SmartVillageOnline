using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel;

namespace DAL.Mapping
{
	class HouseMap : EntityTypeConfiguration<House>
	{
		public HouseMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
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
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Peoples).WithRequired(p => p.Houses).HasForeignKey(p => p.HouseId);

			ToTable("House");
		}
	}
}
