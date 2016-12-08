using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class PersonMap : BaseModelMap<Person>
	{
		public PersonMap()
		{
			Property(t => t.FirstName).IsRequired().HasMaxLength(60);
			Property(t => t.LastName).IsRequired().HasMaxLength(60);
			Property(t => t.MiddleName).IsRequired().HasMaxLength(60);
			Property(t => t.DateBirth).IsRequired();
			Property(t => t.Sex).IsRequired();
			Property(t => t.IsResident).IsRequired();
			Property(t => t.AddressBirthId).IsOptional();
			Property(t => t.AddressLiveId).IsOptional();
			Property(t => t.NationalityId).IsOptional();
			Property(t => t.IdentificationCode).IsOptional().HasMaxLength(10);
			Property(t => t.PassSeria).IsOptional().HasMaxLength(2);
			Property(t => t.PassNr).IsOptional();
			Property(t => t.PassDate).IsOptional();
			Property(t => t.PassAuthorityId).IsOptional();
			Property(t => t.FamilyStatusId).IsOptional();
			Property(t => t.CitizenshipId).IsOptional();
			Property(t => t.CatalogId).IsRequired();
			Property(t => t.IsSojourn).IsRequired();
			Property(t => t.Photo).IsOptional();
			Property(t => t.PadFirstName).IsOptional().HasMaxLength(60);
			Property(t => t.PadName).IsOptional().HasMaxLength(60);
			Property(t => t.PadLastName).IsOptional().HasMaxLength(60);
			Property(t => t.DatFirstName).IsOptional().HasMaxLength(60);
			Property(t => t.DatName).IsOptional().HasMaxLength(60);
			Property(t => t.DatLastName).IsOptional().HasMaxLength(60);
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Peoples).WithRequired(p => p.Persons).HasForeignKey(p => p.PersonId);
			HasMany(a => a.Educations).WithRequired(p => p.Person).HasForeignKey(p => p.PersonId);
			HasMany(a => a.PersonDocuments).WithRequired(p => p.Person).HasForeignKey(p => p.PersonId);
			HasMany(a => a.Employments).WithRequired(p => p.Person).HasForeignKey(p => p.PersonId);

			ToTable("Person");
		}
	}
}
