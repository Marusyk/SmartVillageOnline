﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities;

namespace DataModel.Mapping
{
    public class PeopleMap : EntityTypeConfiguration<People>
    {
        public PeopleMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.PersonID).IsRequired();
            Property(t => t.HouseID).IsRequired();
            Property(t => t.PeopleNumber).IsRequired();
            Property(t => t.IsMain).IsRequired();            
            Property(t => t.LastUpdUS).IsRequired().HasMaxLength(50);
            ToTable("People");
        }
    }
}
