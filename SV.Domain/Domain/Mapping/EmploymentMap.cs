﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities;

namespace Domain.Mapping
{
    public class EmploymentMap : EntityTypeConfiguration<Employment>
    {
        public EmploymentMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.PersonID).IsRequired();
            Property(t => t.Description).HasMaxLength(500);
            Property(t => t.LastUpdUS).IsRequired().HasMaxLength(50);
            ToTable("Employment");
        }
    }
}
