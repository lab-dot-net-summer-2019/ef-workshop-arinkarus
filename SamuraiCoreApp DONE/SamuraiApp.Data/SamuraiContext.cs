using Microsoft.EntityFrameworkCore;
using SamuraiApp.Data.DBMap;
using SamuraiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {
        public SamuraiContext()
        {
        }

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }
        

        public DbSet<SamuraiDepartment> SamuraiDepartments { get; set; }
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new SamuraiBattleMap());
            modelBuilder
                .ApplyConfiguration(new SamuraiMap());
            modelBuilder
                .ApplyConfiguration(new QuoteMap());
            modelBuilder
                .ApplyConfiguration(new SecretIdentityMap());
            modelBuilder
                .ApplyConfiguration(new SamuraiDepartmentMap());
            modelBuilder
                .ApplyConfiguration(new BattleMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
