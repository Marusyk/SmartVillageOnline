using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class AddressMap : EntityTypeConfiguration<Address>
	{
		public AddressMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.CityId).IsRequired();
			Property(t => t.BuildNr).HasMaxLength(10);
			Property(t => t.FlatNr).HasMaxLength(10);
			HasMany(a => a.Houses).WithRequired(p => p.Address).HasForeignKey(p => p.AddressId);
			HasMany(a => a.PersonBirthAddress).WithOptional(p => p.AddressBith).HasForeignKey(p => p.AddressBirthId);
			HasMany(a => a.PersonLiveAddress).WithOptional(p => p.AddressLive).HasForeignKey(p => p.AddressLiveId);
			Property(t => t.CouncilId).IsRequired();
			Property(t => t.LastUpdUs).HasMaxLength(50);
			ToTable("Address");
		}
	}
}
