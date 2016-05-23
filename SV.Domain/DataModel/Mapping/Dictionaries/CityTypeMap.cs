﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class CityTypeMap : EntityTypeConfiguration<CityType>
    {
        public CityTypeMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            HasMany(a => a.Cities).WithRequired(p => p.CityType).HasForeignKey(p => p.CityTypeID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("CityType");
        }
    }
}

