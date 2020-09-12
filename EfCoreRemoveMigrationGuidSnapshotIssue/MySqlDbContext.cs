using Microsoft.EntityFrameworkCore;

namespace EfCoreRemoveMigrationSnapshot
{
    public class MySqlDbContext : DbContext
    {
        public DbSet<EntityWithGuid> EntitiesWithGuid { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => _ = optionsBuilder
                .UseMySql("Server=localhost;Port=33099;Database=testDb;Uid=root;Pwd=Test12345");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var builder = modelBuilder.Entity<EntityWithGuid>();

            _ = builder.HasKey(e => e.Id);

            _ = builder.Property(e => e.RequiredGuid)
                .IsRequired();

            _ = builder.Property(e => e.OptionalGuid);

            _ = builder.Property(e => e.Name)
                .IsRequired();
        }
    }
}
