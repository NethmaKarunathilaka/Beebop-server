using Microsoft.EntityFrameworkCore;
using Bee_bop.Models;
namespace Bee_bop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasOne(d => d.user)
                    .WithMany(p => p.messages)
                    .HasForeignKey(d => d.user_id);

            });
        }
    }
}
