using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Data.DBMap
{
    public class SamuraiDepartmentMap : IEntityTypeConfiguration<SamuraiDepartment>
    {
        public void Configure(EntityTypeBuilder<SamuraiDepartment> builder)
        {
            builder.HasKey(sd => sd.Id);
            builder.Property(s => s.Name)
                .HasMaxLength(40);
        }
    }
}
