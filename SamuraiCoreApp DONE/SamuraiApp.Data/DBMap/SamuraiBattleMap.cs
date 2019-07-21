using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SamuraiApp.Data.DBMap
{
    public class SamuraiBattleMap : IEntityTypeConfiguration<SamuraiBattle>
    {
        public void Configure(EntityTypeBuilder<SamuraiBattle> builder)
        {
            builder
                .HasKey(s => new { s.BattleId, s.SamuraiId });

            builder
                .HasOne(sb => sb.Battle)
                .WithMany(b => b.SamuraiBattles)
                .HasForeignKey(sb => new { sb.BattleId });

            builder
                .HasOne(sb => sb.Samurai)
                .WithMany(s => s.SamuraiBattles)
                .HasForeignKey(sb => new { sb.SamuraiId });
        }
    }
}
