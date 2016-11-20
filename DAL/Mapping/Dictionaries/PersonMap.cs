using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.FirstName).IsRequired().HasMaxLength(60);
            Property(t => t.LastName).IsRequired().HasMaxLength(60);
            Property(t => t.MiddleName).IsRequired().HasMaxLength(60);
            Property(t => t.DateBirth).IsRequired();
            Property(t => t.Sex).IsRequired();
            Property(t => t.IdentificationCode).HasMaxLength(10);
            Property(t => t.PassSeria).HasMaxLength(2);
            Property(t => t.CatalogId).IsRequired();
            Property(t => t.PadFirstName).HasMaxLength(60);
            Property(t => t.PadName).HasMaxLength(60);
            Property(t => t.PadLastName).HasMaxLength(60);
            Property(t => t.DatFirstName).HasMaxLength(60);
            Property(t => t.DatName).HasMaxLength(60);
            Property(t => t.DatLastName).HasMaxLength(60);
            HasMany(a => a.Peoples).WithRequired(p => p.Persons).HasForeignKey(p => p.PersonID);
            HasMany(a => a.Educations).WithRequired(p => p.Person).HasForeignKey(p => p.PersonID);
            HasMany(a => a.PersonDocuments).WithRequired(p => p.Person).HasForeignKey(p => p.PersonID);
            HasMany(a => a.Employments).WithRequired(p => p.Person).HasForeignKey(p => p.PersonID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("Person");
        }
    }
}
