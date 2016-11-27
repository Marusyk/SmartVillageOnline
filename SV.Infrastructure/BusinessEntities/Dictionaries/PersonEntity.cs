using System;
using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class PersonEntity : BaseBusinessCouncilEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public DateTime DateBirth { get; set; }
		public bool? Sex { get; set; }
		public bool IsResident { get; set; }
		public int? AddressBirthId { get; set; }
		public int? AddressLiveId { get; set; }
		public int? NationalityId { get; set; }
		public string IdentificationCode { get; set; }
		public string PassSeria { get; set; }
		public int? PassNr { get; set; }
		public DateTime? PassDate { get; set; }
		public int? PassAuthorityId { get; set; }
		public int? FamilyStatusId { get; set; }
		public int? CitizenshipId { get; set; }
		public int CatalogId { get; set; }
		public bool IsSojourn { get; set; }
		public byte? Photo { get; set; }
		public string PadFirstName { get; set; }
		public string PadName { get; set; }
		public string PadLastName { get; set; }
		public string DatFirstName { get; set; }
		public string DatName { get; set; }
		public string DatLastName { get; set; }

		public virtual AddressEntity AddressBith { get; set; }
		public virtual AddressEntity AddressLive { get; set; }
		public virtual NationalityEntity Nationality { get; set; }
		public virtual PassAuthorityEntity PassAuthority { get; set; }
		public virtual FamilyStatusEntity FamilyStatus { get; set; }
		public virtual CountryEntity Citizenship { get; set; }
		public virtual CatalogEntity Catalog { get; set; }

		public virtual ICollection<PeopleEntity> Peoples { get; set; }
		public virtual ICollection<EducationEntity> Educations { get; set; }
		public virtual ICollection<PersonDocumentEntity> PersonDocuments { get; set; }
		public virtual ICollection<EmploymentEntity> Employments { get; set; }
	}
}
