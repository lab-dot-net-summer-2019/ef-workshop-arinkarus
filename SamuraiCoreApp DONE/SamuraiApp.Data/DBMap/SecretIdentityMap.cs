using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamuraiApp.Domain;
using System;

namespace SamuraiApp.Data.DBMap
{
    public class SecretIdentityMap : IEntityTypeConfiguration<SecretIdentity>
    {
        public void Configure(EntityTypeBuilder<SecretIdentity> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.RealName)
                .HasMaxLength(40);
        }
    }
}
