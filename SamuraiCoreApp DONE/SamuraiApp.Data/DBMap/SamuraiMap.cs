using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SamuraiApp.Data.DBMap
{
    public class SamuraiMap : IEntityTypeConfiguration<Samurai>
    {
        public void Configure(EntityTypeBuilder<Samurai> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id)
                .HasColumnName("SamuraiId");
            builder.Property(s => s.Surname)
                .HasColumnName("Surname")
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(s => s.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .IsRequired();
            builder
                .HasMany(s => s.Quotes)
                .WithOne(s => s.Samurai)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.SamuraiId);
            builder
                .HasMany(sb => sb.SamuraiBattles)
                .WithOne(s => s.Samurai)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.SamuraiId);
            builder
                .HasOne(s => s.SamuraiDepartment)
                .WithMany(s => s.Samurais)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(s => s.SamuraiDepartmentId);
            builder
                .HasOne(s => s.SecretIdentity)
                .WithOne(s => s.Samurai)
                .IsRequired();
            builder.Property(s => s.SamuraiDepartmentId)
                .HasColumnName("SamuraiDepartmentId");           
        }
    }
}
